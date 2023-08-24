#include <vector>
#include "includes\PFile.h"
#include "includes\PIO.hpp"
#include "quote\base64.hpp"

constexpr int minp = 4, maxp = 6;
long long getkey(const std::string &s);

int main(int argc, char **argv)
{
    // 参数数量校验
    if (argc < minp || argc > maxp)
    {
        Pprint("Usage:encrypt (encode|decode) <file> <password> [<output>]");
        return 1;
    }

    // 复制原参数
    std::vector<std::string> per(argc);
    for (auto i = 0; i <= argc - 1; i++)
        per[i] = argv[i];

    // 检查选项参数
    if (per[1] != "encode" && per[1] != "decode")
    {
        Pprint("Undefined option!", P_RED);
        return 2;
    }

    // 初始化输入输出路径
    std::string input, output;
    input = Pgetfullpath(per[0], per[2]);
    if (argc == minp)
        output = Pgetinpath(input);
    else if (argc == maxp)
    {
        if (per[4] == "null" && per[5] == "official-hack") // for ui to hack
            output = Pgetinpath(input);
        else
            output = Pgetfullpath(per[0], per[4]);
    }
    else
        output = Pgetfullpath(per[0], per[4]);

    // 检查文件是否存在
    if (Pcheck(input) != 1)
    {
        Pprint("No this file!", P_RED);
        return 3;
    }

    // 确定输出文件完整路径
    if (Pcheck(output) == 0)
    {
        if (output.back() != '\\')
            output += '\\';
        std::string filename = input.substr(input.rfind('\\') + 1);
        if (per[1] == "encode")
        {
            filename = base64::to_base64(filename);
            while (filename.back() == '=')
                filename.erase(filename.end() - 1);
            output += filename;
        }
        else
        {
            while (filename.length() % 4)
                filename += '=';
            filename = base64::from_base64(filename);
            output += filename;
        }
    }

    //  计算key值
    long long key = getkey(per[3]);

    //// 加密

    // for ui to hack
    if (per[5] != "official-hack")
        Pprint("Running......\n");

    if (!Pcopy(input, output, key))
    {
        Pprint("Unknown Error", P_RED);
        return 4;
    }

    // for ui to hack
    if (per[5] == "official-hack")
    {
        Pprint(output);
        return 404;
    }

    if (per[1] == "encode")
        Pprint("Encoded");
    else
        Pprint("Decoded");
    Pprint(" File is declared to: ");
    Pprint(output, P_BLUE);
    // 退出程序
    return 0;
}

long long getkey(const std::string &s)
{
    constexpr int mod1 = 1919810, mod2 = 998244353;
    long long key = 0, base = 1;
    for (auto i : s)
        key += i * base, base *= 10, base %= mod1, key %= mod2;
    return key;
}

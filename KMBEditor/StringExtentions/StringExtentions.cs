﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KMBEditor.StringExtentions
{
    /// <summary>
    /// stringの拡張メソッドを定義
    /// </summary>
    public static class StringExtentions
    {
        /// <summary>
        /// Shift_JIS(cp932)での総バイト数を取得
        /// </summary>
        /// <param name="str"></param>
        /// <returns>総バイト数</returns>
        public static int GetShift_JISByteCount(this string str)
        {
            return Encoding.GetEncoding(932).GetByteCount(str);
        }

        /// <summary>
        /// 文字列の総行数を取得(改行コードをカウント)
        /// </summary>
        /// <param name="str"></param>
        /// <returns>総行数</returns>
        public static int GetLineCount(this string str)
        {
            int n = 0;
            foreach (var c in str)
            {
                // 改行が'\r\n'でも'\n'は含まれているので行数カウントには問題ない
                if (c == '\n') n++;
            }
            return n + 1;
        }

        /// <summary>
        /// IsCaptionで使用する正規表現の事前コンパイル
        /// </summary>
        private readonly static Regex _caption_regx = new Regex(@"^【.*】$", RegexOptions.Compiled);

        /// <summary>
        /// 見出しページかの判定
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsCaption(this string str)
        {
            return _caption_regx.IsMatch(str);
        }

        public static IEnumerable<string> ReadLine(this string str)
        {
            if (str != null)
            {
                var lines = str.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
                foreach (var line in lines)
                {
                    yield return line;
                }
            }
        }
    }
}

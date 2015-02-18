using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodMood.Extensions
{
    static class StringExtension
    {
        public static string JsonEscape(this string data)
        {
            var escaped = new StringBuilder();

            foreach(var ch in data)
            {
                switch(ch)
                {
                    case '"':
                    case '\\':
                    case '/':
                        escaped.Append('\\');
                        escaped.Append(ch);
                        break;
                    case '\n':
                        escaped.Append("\\n");
                        break;
                    case '\t':
                        escaped.Append("\\t");
                        break;
                    case '\r':
                        escaped.Append("\\r");
                        break;
                    default:
                        if (!char.IsWhiteSpace(ch) && char.IsControl(ch))
                        {
                            escaped.AppendFormat("\\u{0:000}", (int)ch);
                        }
                        else
                        {
                            escaped.Append(ch);
                        }
                        break;
                }
            }

            return escaped.ToString();
        }
    }
}

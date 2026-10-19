using System;
using System.Globalization;

namespace lab2
{
    public class ExpressionEvaluator
    {
        private string text;
        private int position;

        public double Evaluate(string expression)
        {

            text = expression
                .Replace('–', '-')
                .Replace('—', '-')
                .Replace('×', '*')
                .Replace('÷', '/')
                .Replace(" ", "")
                .Replace("\t", "");
            position = 0;

            double result = ParseExpression();

            if (position < text.Length)
                throw new FormatException("Ký tự thừa hoặc biểu thức không hợp lệ");

            return result;
        }

        private double ParseExpression()
        {
            double value = ParseTerm();

            while (position < text.Length && (text[position] == '+' || text[position] == '-'))
            {
                char op = text[position];
                position++;
                double right = ParseTerm();
                value = (op == '+') ? value + right : value - right;
            }
            return value;
        }

        private double ParseTerm()
        {
            double value = ParseFactor();

            while (position < text.Length && (text[position] == '*' || text[position] == '/'))
            {
                char op = text[position];
                position++;
                double right = ParseFactor();

                if (op == '/' && right == 0)
                    throw new DivideByZeroException("Chia cho 0");

                value = (op == '*') ? value * right : value / right;
            }
            return value;
        }
        private double ParseFactor()
        {
            if (position >= text.Length)
                throw new FormatException("Thiếu toán hạng");

            char current = text[position];

            if (current == '-') { position++; return -ParseFactor(); }
            if (current == '+') { position++; return ParseFactor(); }

            if (current == '(')
            {
                position++;                       
                double value = ParseExpression(); 
                if (position >= text.Length || text[position] != ')')
                    throw new FormatException("Thiếu dấu )");
                position++;                       
                return value;
            }

            return ParseNumber();
        }

        private double ParseNumber()
        {
            int start = position;
            while (position < text.Length && (char.IsDigit(text[position]) || text[position] == '.'))
                position++;

            if (start == position)
                throw new FormatException("Ký tự không hợp lệ: '" + text[position] + "'");

            string numberText = text.Substring(start, position - start);
            return double.Parse(numberText, CultureInfo.InvariantCulture);
        }
    }
}
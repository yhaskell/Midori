﻿namespace Midori.Lexer
{
    class Const
    {
        public object Value { get; set; }

        public enum ConstType { Character, String, Decimal, Integral, Boolean, Null }

        public ConstType Type { get; set; }
    }

    class Keyword : IToken { // change to enum of keywords
        public enum KeywordType { Func, Is, While, Do, Yield, Return, Break, Continue, Where, While, If, Then, Else, For, In, Type, Operator, Get, New, Assert, Head, Tail }
        public KeywordType Value { get; set; }
    }

    class Identifier : IToken {
        public string Name { get; set; }
    }

    class Operator : IToken { // change to enum of punctuators
        public enum OperatorType
        {
            Exclamation, At, Sharp, Dollar, Percent, Power, And, Multiply, OpeningParenthese, ClosingParenthese, Minus, Plus, Equal, Or, Slash,
            Dot, Comma, Less, Greater, Question, Quote, Colon, SemiColon, OpeningSB, ClosingSB, OpeningCB, ClosingCB, Apostroph, ReverseApostroph, Tilde,
            LessEq, GreaterEq, Equals, NotEquals, ShiftRight, ShiftLeft
            //! @ # $ % ^ & * ( ) - + = | / . , < > ? " : ; [ ] { } ' ` ~ <= >= == != >> << 
        }
        public OperatorType Value { get; set; }
    }

    namespace Block
    {
        class Start : IToken { }
        class End : IToken { }
    }
}

Lexer



IToken - parent interface


Types of tokens:
================
	
-	Constant
├		Character					'c'
├		String						"test123 \n \t \\ \"mhal\"";        @'test \n  "test" '
├		Float						123.45   // postfixes are: f for float, m for decimal
├		Integer						+473856  // postfixes are: u for unsigned, s for short, l for long
├		Boolean						true | false
└		Null						null
-	Keyword							(list of keywods)
-	Identifier						test _init m_BigValue123
-	Operator						! @ # $ % ^ & * ( ) - + = | / . , < > ? " : ; [ ] { } ` ~ <= >= == != >> << 
-	Block
├		Start
└		End

Parsing process:
================

1) parse to constants, identifiers, operators and blocks
2) when generating, try to generate keywords from identifiers
3) don't forget generating block tokens when needed

// $ANTLR 3.2 Sep 23, 2009 12:02:23 Conf.g 2012-12-17 17:43:49

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  Antlr.Sample.ConfReader 
{
public partial class ConfLexer : Lexer {
    public const int WS = 8;
    public const int NEWLINE = 4;
    public const int T__11 = 11;
    public const int T__10 = 10;
    public const int INT = 6;
    public const int ID = 5;
    public const int COMMENT = 7;
    public const int EOF = -1;
    public const int T__9 = 9;

    // delegates
    // delegators

    public ConfLexer() 
    {
		InitializeCyclicDFAs();
    }
    public ConfLexer(ICharStream input)
		: this(input, null) {
    }
    public ConfLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Conf.g";} 
    }

    // $ANTLR start "T__9"
    public void mT__9() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__9;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:9:6: ( '(' )
            // Conf.g:9:8: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__9"

    // $ANTLR start "T__10"
    public void mT__10() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__10;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:10:7: ( ')' )
            // Conf.g:10:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__10"

    // $ANTLR start "T__11"
    public void mT__11() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__11;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:11:7: ( ',' )
            // Conf.g:11:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__11"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:27:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // Conf.g:27:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// Conf.g:27:31: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Conf.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:30:5: ( ( '0' .. '9' )+ )
            // Conf.g:30:7: ( '0' .. '9' )+
            {
            	// Conf.g:30:7: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Conf.g:30:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:34:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0 == '/') )
            {
                int LA6_1 = input.LA(2);

                if ( (LA6_1 == '/') )
                {
                    alt6 = 1;
                }
                else if ( (LA6_1 == '*') )
                {
                    alt6 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d6s1 =
                        new NoViableAltException("", 6, 1, input);

                    throw nvae_d6s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // Conf.g:34:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// Conf.g:34:14: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= '\u0000' && LA3_0 <= '\t') || (LA3_0 >= '\u000B' && LA3_0 <= '\f') || (LA3_0 >= '\u000E' && LA3_0 <= '\uFFFF')) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // Conf.g:34:14: ~ ( '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop3;
                    	    }
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements

                    	// Conf.g:34:28: ( '\\r' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == '\r') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // Conf.g:34:28: '\\r'
                    	        {
                    	        	Match('\r'); 

                    	        }
                    	        break;

                    	}

                    	Match('\n'); 
                    	_channel=HIDDEN;

                    }
                    break;
                case 2 :
                    // Conf.g:35:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    	Match("/*"); 

                    	// Conf.g:35:14: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( (LA5_0 == '*') )
                    	    {
                    	        int LA5_1 = input.LA(2);

                    	        if ( (LA5_1 == '/') )
                    	        {
                    	            alt5 = 2;
                    	        }
                    	        else if ( ((LA5_1 >= '\u0000' && LA5_1 <= '.') || (LA5_1 >= '0' && LA5_1 <= '\uFFFF')) )
                    	        {
                    	            alt5 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA5_0 >= '\u0000' && LA5_0 <= ')') || (LA5_0 >= '+' && LA5_0 <= '\uFFFF')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // Conf.g:35:42: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop5;
                    	    }
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	Match("*/"); 

                    	_channel=HIDDEN;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:38:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // Conf.g:38:9: ( ' ' | '\\t' | '\\r' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "NEWLINE"
    public void mNEWLINE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEWLINE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:45:9: ( ( '\\r' )? '\\n' )
            // Conf.g:45:11: ( '\\r' )? '\\n'
            {
            	// Conf.g:45:11: ( '\\r' )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == '\r') )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // Conf.g:45:11: '\\r'
            	        {
            	        	Match('\r'); 

            	        }
            	        break;

            	}

            	Match('\n'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEWLINE"

    override public void mTokens() // throws RecognitionException 
    {
        // Conf.g:1:8: ( T__9 | T__10 | T__11 | ID | INT | COMMENT | WS | NEWLINE )
        int alt8 = 8;
        alt8 = dfa8.Predict(input);
        switch (alt8) 
        {
            case 1 :
                // Conf.g:1:10: T__9
                {
                	mT__9(); 

                }
                break;
            case 2 :
                // Conf.g:1:15: T__10
                {
                	mT__10(); 

                }
                break;
            case 3 :
                // Conf.g:1:21: T__11
                {
                	mT__11(); 

                }
                break;
            case 4 :
                // Conf.g:1:27: ID
                {
                	mID(); 

                }
                break;
            case 5 :
                // Conf.g:1:30: INT
                {
                	mINT(); 

                }
                break;
            case 6 :
                // Conf.g:1:34: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 7 :
                // Conf.g:1:42: WS
                {
                	mWS(); 

                }
                break;
            case 8 :
                // Conf.g:1:45: NEWLINE
                {
                	mNEWLINE(); 

                }
                break;

        }

    }


    protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
	    this.dfa8 = new DFA8(this);
	}

    const string DFA8_eotS =
        "\x07\uffff\x01\x09\x03\uffff";
    const string DFA8_eofS =
        "\x0b\uffff";
    const string DFA8_minS =
        "\x01\x09\x06\uffff\x01\x0a\x03\uffff";
    const string DFA8_maxS =
        "\x01\x7a\x06\uffff\x01\x0a\x03\uffff";
    const string DFA8_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\uffff\x02\x07\x01\x08";
    const string DFA8_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x09\x01\x08\x02\uffff\x01\x07\x12\uffff\x01\x09\x07\uffff"+
            "\x01\x01\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x06\x0a\x05"+
            "\x07\uffff\x1a\x04\x04\uffff\x01\x04\x01\uffff\x1a\x04",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0a",
            "",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__9 | T__10 | T__11 | ID | INT | COMMENT | WS | NEWLINE );"; }
        }

    }

 
    
}
}
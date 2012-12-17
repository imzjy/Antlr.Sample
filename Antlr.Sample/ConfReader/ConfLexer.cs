// $ANTLR 3.2 Sep 23, 2009 12:02:23 Conf.g 2012-12-17 15:48:35

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
    public const int WS = 6;
    public const int FUNC = 4;
    public const int EOF = -1;
    public const int T__8 = 8;
    public const int T__7 = 7;
    public const int PARAMS = 5;

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

    // $ANTLR start "T__7"
    public void mT__7() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__7;
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
    // $ANTLR end "T__7"

    // $ANTLR start "T__8"
    public void mT__8() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__8;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:10:6: ( ')' )
            // Conf.g:10:8: ')'
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
    // $ANTLR end "T__8"

    // $ANTLR start "FUNC"
    public void mFUNC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FUNC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:12:7: ( ( 'A' .. 'Z' )+ )
            // Conf.g:12:11: ( 'A' .. 'Z' )+
            {
            	// Conf.g:12:11: ( 'A' .. 'Z' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= 'A' && LA1_0 <= 'Z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Conf.g:12:12: 'A' .. 'Z'
            			    {
            			    	MatchRange('A','Z'); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
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
    // $ANTLR end "FUNC"

    // $ANTLR start "PARAMS"
    public void mPARAMS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PARAMS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:13:9: ( ( '0' .. '9' )+ )
            // Conf.g:13:13: ( '0' .. '9' )+
            {
            	// Conf.g:13:13: ( '0' .. '9' )+
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
            			    // Conf.g:13:14: '0' .. '9'
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
    // $ANTLR end "PARAMS"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Conf.g:14:5: ( ( ' ' | '\\t' )+ )
            // Conf.g:14:9: ( ' ' | '\\t' )+
            {
            	// Conf.g:14:9: ( ' ' | '\\t' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == '\t' || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Conf.g:
            			    {
            			    	if ( input.LA(1) == '\t' || input.LA(1) == ' ' ) 
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
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	 Skip(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // Conf.g:1:8: ( T__7 | T__8 | FUNC | PARAMS | WS )
        int alt4 = 5;
        switch ( input.LA(1) ) 
        {
        case '(':
        	{
            alt4 = 1;
            }
            break;
        case ')':
        	{
            alt4 = 2;
            }
            break;
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        	{
            alt4 = 3;
            }
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        	{
            alt4 = 4;
            }
            break;
        case '\t':
        case ' ':
        	{
            alt4 = 5;
            }
            break;
        	default:
        	    NoViableAltException nvae_d4s0 =
        	        new NoViableAltException("", 4, 0, input);

        	    throw nvae_d4s0;
        }

        switch (alt4) 
        {
            case 1 :
                // Conf.g:1:10: T__7
                {
                	mT__7(); 

                }
                break;
            case 2 :
                // Conf.g:1:15: T__8
                {
                	mT__8(); 

                }
                break;
            case 3 :
                // Conf.g:1:20: FUNC
                {
                	mFUNC(); 

                }
                break;
            case 4 :
                // Conf.g:1:25: PARAMS
                {
                	mPARAMS(); 

                }
                break;
            case 5 :
                // Conf.g:1:32: WS
                {
                	mWS(); 

                }
                break;

        }

    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
}
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



using Antlr.Runtime.Tree;

namespace  Antlr.Sample.ConfReader 
{
public partial class ConfParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"NEWLINE", 
		"ID", 
		"INT", 
		"COMMENT", 
		"WS", 
		"'('", 
		"')'", 
		"','"
    };

    public const int WS = 8;
    public const int NEWLINE = 4;
    public const int T__11 = 11;
    public const int T__10 = 10;
    public const int INT = 6;
    public const int COMMENT = 7;
    public const int ID = 5;
    public const int EOF = -1;
    public const int T__9 = 9;

    // delegates
    // delegators



        public ConfParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public ConfParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return ConfParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Conf.g"; }
    }


    public class prog_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "prog"
    // Conf.g:11:1: prog : ( stat )+ ;
    public ConfParser.prog_return prog() // throws RecognitionException [1]
    {   
        ConfParser.prog_return retval = new ConfParser.prog_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        ConfParser.stat_return stat1 = default(ConfParser.stat_return);



        try 
    	{
            // Conf.g:11:8: ( ( stat )+ )
            // Conf.g:11:10: ( stat )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Conf.g:11:10: ( stat )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= NEWLINE && LA1_0 <= ID)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Conf.g:11:10: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_prog52);
            			    	stat1 = stat();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, stat1.Tree);

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

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "prog"

    public class stat_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "stat"
    // Conf.g:14:1: stat : ( expr NEWLINE -> expr | NEWLINE ->);
    public ConfParser.stat_return stat() // throws RecognitionException [1]
    {   
        ConfParser.stat_return retval = new ConfParser.stat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NEWLINE3 = null;
        IToken NEWLINE4 = null;
        ConfParser.expr_return expr2 = default(ConfParser.expr_return);


        object NEWLINE3_tree=null;
        object NEWLINE4_tree=null;
        RewriteRuleTokenStream stream_NEWLINE = new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor,"rule expr");
        try 
    	{
            // Conf.g:14:8: ( expr NEWLINE -> expr | NEWLINE ->)
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == ID) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == NEWLINE) )
            {
                alt2 = 2;
            }
            else 
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // Conf.g:14:10: expr NEWLINE
                    {
                    	PushFollow(FOLLOW_expr_in_stat71);
                    	expr2 = expr();
                    	state.followingStackPointer--;

                    	stream_expr.Add(expr2.Tree);
                    	NEWLINE3=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_stat73);  
                    	stream_NEWLINE.Add(NEWLINE3);



                    	// AST REWRITE
                    	// elements:          expr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 14:23: -> expr
                    	{
                    	    adaptor.AddChild(root_0, stream_expr.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // Conf.g:15:10: NEWLINE
                    {
                    	NEWLINE4=(IToken)Match(input,NEWLINE,FOLLOW_NEWLINE_in_stat88);  
                    	stream_NEWLINE.Add(NEWLINE4);



                    	// AST REWRITE
                    	// elements:          
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 15:18: ->
                    	{
                    	    root_0 = null;
                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "stat"

    public class expr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // Conf.g:18:1: expr : fname '(' parms ')' ;
    public ConfParser.expr_return expr() // throws RecognitionException [1]
    {   
        ConfParser.expr_return retval = new ConfParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal6 = null;
        IToken char_literal8 = null;
        ConfParser.fname_return fname5 = default(ConfParser.fname_return);

        ConfParser.parms_return parms7 = default(ConfParser.parms_return);


        object char_literal6_tree=null;
        object char_literal8_tree=null;

        try 
    	{
            // Conf.g:18:8: ( fname '(' parms ')' )
            // Conf.g:18:10: fname '(' parms ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_fname_in_expr108);
            	fname5 = fname();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, fname5.Tree);
            	char_literal6=(IToken)Match(input,9,FOLLOW_9_in_expr110); 
            		char_literal6_tree = (object)adaptor.Create(char_literal6);
            		adaptor.AddChild(root_0, char_literal6_tree);

            	PushFollow(FOLLOW_parms_in_expr112);
            	parms7 = parms();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, parms7.Tree);
            	char_literal8=(IToken)Match(input,10,FOLLOW_10_in_expr114); 
            		char_literal8_tree = (object)adaptor.Create(char_literal8);
            		adaptor.AddChild(root_0, char_literal8_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class fname_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "fname"
    // Conf.g:21:1: fname : ID ;
    public ConfParser.fname_return fname() // throws RecognitionException [1]
    {   
        ConfParser.fname_return retval = new ConfParser.fname_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ID9 = null;

        object ID9_tree=null;

        try 
    	{
            // Conf.g:21:8: ( ID )
            // Conf.g:21:10: ID
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ID9=(IToken)Match(input,ID,FOLLOW_ID_in_fname131); 
            		ID9_tree = (object)adaptor.Create(ID9);
            		adaptor.AddChild(root_0, ID9_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "fname"

    public class parms_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parms"
    // Conf.g:24:1: parms : INT ( ',' INT )* ;
    public ConfParser.parms_return parms() // throws RecognitionException [1]
    {   
        ConfParser.parms_return retval = new ConfParser.parms_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT10 = null;
        IToken char_literal11 = null;
        IToken INT12 = null;

        object INT10_tree=null;
        object char_literal11_tree=null;
        object INT12_tree=null;

        try 
    	{
            // Conf.g:24:8: ( INT ( ',' INT )* )
            // Conf.g:24:10: INT ( ',' INT )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT10=(IToken)Match(input,INT,FOLLOW_INT_in_parms155); 
            		INT10_tree = (object)adaptor.Create(INT10);
            		adaptor.AddChild(root_0, INT10_tree);

            	// Conf.g:24:14: ( ',' INT )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == 11) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Conf.g:24:15: ',' INT
            			    {
            			    	char_literal11=(IToken)Match(input,11,FOLLOW_11_in_parms158); 
            			    		char_literal11_tree = (object)adaptor.Create(char_literal11);
            			    		adaptor.AddChild(root_0, char_literal11_tree);

            			    	INT12=(IToken)Match(input,INT,FOLLOW_INT_in_parms160); 
            			    		INT12_tree = (object)adaptor.Create(INT12);
            			    		adaptor.AddChild(root_0, INT12_tree);


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parms"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_stat_in_prog52 = new BitSet(new ulong[]{0x0000000000000032UL});
    public static readonly BitSet FOLLOW_expr_in_stat71 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_stat73 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NEWLINE_in_stat88 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_fname_in_expr108 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_9_in_expr110 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_parms_in_expr112 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_expr114 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_fname131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_parms155 = new BitSet(new ulong[]{0x0000000000000802UL});
    public static readonly BitSet FOLLOW_11_in_parms158 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_INT_in_parms160 = new BitSet(new ulong[]{0x0000000000000802UL});

}
}
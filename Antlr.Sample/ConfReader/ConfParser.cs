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
		"FUNC", 
		"PARAMS", 
		"WS", 
		"'('", 
		"')'"
    };

    public const int WS = 6;
    public const int FUNC = 4;
    public const int EOF = -1;
    public const int T__8 = 8;
    public const int T__7 = 7;
    public const int PARAMS = 5;

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
    // Conf.g:11:1: stat : FUNC '(' PARAMS ')' ;
    public ConfParser.stat_return stat() // throws RecognitionException [1]
    {   
        ConfParser.stat_return retval = new ConfParser.stat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FUNC1 = null;
        IToken char_literal2 = null;
        IToken PARAMS3 = null;
        IToken char_literal4 = null;

        object FUNC1_tree=null;
        object char_literal2_tree=null;
        object PARAMS3_tree=null;
        object char_literal4_tree=null;

        try 
    	{
            // Conf.g:11:5: ( FUNC '(' PARAMS ')' )
            // Conf.g:11:7: FUNC '(' PARAMS ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	FUNC1=(IToken)Match(input,FUNC,FOLLOW_FUNC_in_stat49); 
            		FUNC1_tree = (object)adaptor.Create(FUNC1);
            		adaptor.AddChild(root_0, FUNC1_tree);

            	char_literal2=(IToken)Match(input,7,FOLLOW_7_in_stat51); 
            		char_literal2_tree = (object)adaptor.Create(char_literal2);
            		adaptor.AddChild(root_0, char_literal2_tree);

            	PARAMS3=(IToken)Match(input,PARAMS,FOLLOW_PARAMS_in_stat53); 
            		PARAMS3_tree = (object)adaptor.Create(PARAMS3);
            		adaptor.AddChild(root_0, PARAMS3_tree);

            	char_literal4=(IToken)Match(input,8,FOLLOW_8_in_stat55); 
            		char_literal4_tree = (object)adaptor.Create(char_literal4);
            		adaptor.AddChild(root_0, char_literal4_tree);


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

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_FUNC_in_stat49 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_7_in_stat51 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_PARAMS_in_stat53 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_8_in_stat55 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}
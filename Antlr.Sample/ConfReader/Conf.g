grammar Conf;

options {
    language=CSharp2;
    output=AST;
}

@parser::namespace { Antlr.Sample.ConfReader }
@lexer::namespace { Antlr.Sample.ConfReader }

stat: FUNC '(' PARAMS ')' ;
FUNC  :   ('A'..'Z')+ ;
PARAMS  :   ('0'..'9')+ ;
WS  :   (' '|'\t')+ { Skip(); } ;

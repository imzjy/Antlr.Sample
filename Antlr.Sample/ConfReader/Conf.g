grammar Conf;

options {
    language=CSharp2;
    output=AST;
}

@parser::namespace { Antlr.Sample.ConfReader }
@lexer::namespace { Antlr.Sample.ConfReader }

prog   : stat+
       ;

stat   : expr NEWLINE -> expr
       | NEWLINE ->
       ;

expr   : fname '(' parms ')'
       ;

fname  : ID
       ;
       
parms  : INT (',' INT)* 
       ;

ID  :	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;

INT :	'0'..'9'+
    ;

COMMENT
    :   '//' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;}
    |   '/*' ( options {greedy=false;} : . )* '*/' {$channel=HIDDEN;}
    ;

WS  :   ( ' '
        | '\t'
        | '\r'
        | '\n'
        ) {$channel=HIDDEN;}
    ;

NEWLINE : '\r'? '\n'
        ;


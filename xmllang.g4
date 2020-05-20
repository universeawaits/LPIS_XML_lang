grammar xmllang;

tale : statement+;

FOR             : 'for each';
IF              : 'if';
IN              : 'in';
TAG             : 'node';
ELSE            : 'else';
ATTR            : 'attr';
NAME            : 'name';
TEXT            : 'text';
NODES           : 'nodes';
ATTRS           : 'attrs';
GEN             : 'generate';
PRINT           : 'print';
VALUE           : 'value';
PARSE           : 'parse';
ARRAY           : 'array';
SWITCH          : 'switch';
CASE            : 'case';
DEFAULT         : 'default';

AT              : '@';
ID              : [a-z_]+;
FILENAME        : [a-zA-Z|~.]+;
STRING          : '"' (.)*? '"';
NEWLINE         : '\r'? '\n' ;
ASSIGN          : '=';
EQ              : '==';
NOT             : '!=';
APPEND_ATTR     : 'adds attr';
APPEND_CHILD    : 'adds child';
REMOVE_ATTR     : 'removes attr';
REMOVE_CHILD    : 'removes child';
ROOT            : '!';
INT             : [0-9]+;
QT              : '"';
COLON           : ':';
OPEN_BRACKET    : '(';
CLOSE_BRACKET   : ')';
SPACE           : ' ';
COMMA           : ',';
ARROW           : '->';
DOT             : '.';
OPEN_BLOCK      : '{';
CLOSE_BLOCK     : '}';
HASHTAG         : '#';

statement: 
      SPACE* TAG SPACE ID OPEN_BRACKET STRING CLOSE_BRACKET NEWLINE                       # tag_assignment
    | SPACE* ATTR SPACE ID OPEN_BRACKET STRING COMMA SPACE STRING CLOSE_BRACKET NEWLINE   # attr_assignment
    | SPACE* GEN OPEN_BRACKET ID COMMA SPACE STRING CLOSE_BRACKET NEWLINE                 # gen_file
    | SPACE* PARSE OPEN_BRACKET ID COMMA SPACE STRING CLOSE_BRACKET NEWLINE               # parse_file
    | SPACE* ID SPACE ASSIGN SPACE STRING NEWLINE                                         # add_text
    | SPACE* ID SPACE APPEND_CHILD SPACE ID NEWLINE                                       # append_tag
    | SPACE* ID SPACE APPEND_ATTR SPACE ID NEWLINE                                        # append_atr
    | SPACE* ID SPACE REMOVE_CHILD SPACE ID NEWLINE                                       # remove_tag
    | SPACE* ID SPACE REMOVE_ATTR SPACE ID NEWLINE                                        # remove_atr
    | SPACE* ARRAY SPACE ID NEWLINE                                                       # declare_array
    | begin_for statement+ end                                                            # for_cycle
    | function_decl statement+ end                                                        # function_declaration
    | ID OPEN_BRACKET (ID(COMMA SPACE ID)*)* CLOSE_BRACKET NEWLINE                        # function_call
    | begin_if statement+ (else_thing statement+)? end                                    # if_declaration
    | SPACE* access_info SPACE ASSIGN SPACE STRING NEWLINE                                # assign_new_value
    | comment                                                                             # comment_fun
    | print_statement                                                                     # print;

access_info:
      ID ARROW NAME     # access_name
    | ID ARROW TEXT     # access_text
    | ID ARROW VALUE    # access_value;

value:
   ID                   #caseId
 | STRING               #caseStr
 | INT                  #caseInt;

case_block:
   CASE value COLON tale
 | DEFAULT COLON tale;

print_statement : PRINT SPACE access_info NEWLINE;

begin_for       : SPACE* FOR SPACE ID SPACE IN SPACE ID SPACE OPEN_BLOCK NEWLINE;
end             : SPACE* CLOSE_BLOCK NEWLINE;
datatype        : TAG | ATTR | ARRAY | 'int';
function_decl   : SPACE* ID OPEN_BRACKET (datatype SPACE ID (COMMA SPACE datatype SPACE ID)*)* CLOSE_BRACKET SPACE OPEN_BLOCK NEWLINE;
begin_if        : IF SPACE comparison SPACE OPEN_BLOCK NEWLINE;
comparison      : access_info SPACE (EQ|NOT) SPACE STRING;
else_thing      : CLOSE_BLOCK SPACE ELSE SPACE OPEN_BLOCK NEWLINE;
comment         : HASHTAG .*? NEWLINE;
switch_stat     : SWITCH ID SPACE OPEN_BLOCK case_block+ CLOSE_BLOCK;
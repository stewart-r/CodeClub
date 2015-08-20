﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Print out the first 5 names in alphabetical order:

            
            //2. How many names begin with the letter "D" (hint: you can do myString.StartsWith("X") to determine if a string starts with "X")?
            

            //3. How many names begin with the letter "A" and are 5 characters long?
            

        }

        static List<string> names = new List<string>()
        {
            "JAMES",
            "JOHN",
            "ROBERT",
            "MICHAEL",
            "WILLIAM",
            "DAVID",
            "RICHARD",
            "CHARLES",
            "JOSEPH",
            "THOMAS",
            "CHRISTOPHER",
            "DANIEL",
            "PAUL",
            "MARK",
            "DONALD",
            "GEORGE",
            "KENNETH",
            "STEVEN",
            "EDWARD",
            "BRIAN",
            "RONALD",
            "ANTHONY",
            "KEVIN",
            "JASON",
            "MATTHEW",
            "GARY",
            "TIMOTHY",
            "JOSE",
            "LARRY",
            "JEFFREY",
            "FRANK",
            "SCOTT",
            "ERIC",
            "STEPHEN",
            "ANDREW",
            "RAYMOND",
            "GREGORY",
            "JOSHUA",
            "JERRY",
            "DENNIS",
            "WALTER",
            "PATRICK",
            "PETER",
            "HAROLD",
            "DOUGLAS",
            "HENRY",
            "CARL",
            "ARTHUR",
            "RYAN",
            "ROGER",
            "JOE",
            "JUAN",
            "JACK",
            "ALBERT",
            "JONATHAN",
            "JUSTIN",
            "TERRY",
            "GERALD",
            "KEITH",
            "SAMUEL",
            "WILLIE",
            "RALPH",
            "LAWRENCE",
            "NICHOLAS",
            "ROY",
            "BENJAMIN",
            "BRUCE",
            "BRANDON",
            "ADAM",
            "HARRY",
            "FRED",
            "WAYNE",
            "BILLY",
            "STEVE",
            "LOUIS",
            "JEREMY",
            "AARON",
            "RANDY",
            "HOWARD",
            "EUGENE",
            "CARLOS",
            "RUSSELL",
            "BOBBY",
            "VICTOR",
            "MARTIN",
            "ERNEST",
            "PHILLIP",
            "TODD",
            "JESSE",
            "CRAIG",
            "ALAN",
            "SHAWN",
            "CLARENCE",
            "SEAN",
            "PHILIP",
            "CHRIS",
            "JOHNNY",
            "EARL",
            "JIMMY",
            "ANTONIO",
            "DANNY",
            "BRYAN",
            "TONY",
            "LUIS",
            "MIKE",
            "STANLEY",
            "LEONARD",
            "NATHAN",
            "DALE",
            "MANUEL",
            "RODNEY",
            "CURTIS",
            "NORMAN",
            "ALLEN",
            "MARVIN",
            "VINCENT",
            "GLENN",
            "JEFFERY",
            "TRAVIS",
            "JEFF",
            "CHAD",
            "JACOB",
            "LEE",
            "MELVIN",
            "ALFRED",
            "KYLE",
            "FRANCIS",
            "BRADLEY",
            "JESUS",
            "HERBERT",
            "FREDERICK",
            "RAY",
            "JOEL",
            "EDWIN",
            "DON",
            "EDDIE",
            "RICKY",
            "TROY",
            "RANDALL",
            "BARRY",
            "ALEXANDER",
            "BERNARD",
            "MARIO",
            "LEROY",
            "FRANCISCO",
            "MARCUS",
            "MICHEAL",
            "THEODORE",
            "CLIFFORD",
            "MIGUEL",
            "OSCAR",
            "JAY",
            "JIM",
            "TOM",
            "CALVIN",
            "ALEX",
            "JON",
            "RONNIE",
            "BILL",
            "LLOYD",
            "TOMMY",
            "LEON",
            "DEREK",
            "WARREN",
            "DARRELL",
            "JEROME",
            "FLOYD",
            "LEO",
            "ALVIN",
            "TIM",
            "WESLEY",
            "GORDON",
            "DEAN",
            "GREG",
            "JORGE",
            "DUSTIN",
            "PEDRO",
            "DERRICK",
            "DAN",
            "LEWIS",
            "ZACHARY",
            "COREY",
            "HERMAN",
            "MAURICE",
            "VERNON",
            "ROBERTO",
            "CLYDE",
            "GLEN",
            "HECTOR",
            "SHANE",
            "RICARDO",
            "SAM",
            "RICK",
            "LESTER",
            "BRENT",
            "RAMON",
            "CHARLIE",
            "TYLER",
            "GILBERT",
            "GENE",
            "MARC",
            "REGINALD",
            "RUBEN",
            "BRETT",
            "ANGEL",
            "NATHANIEL",
            "RAFAEL",
            "LESLIE",
            "EDGAR",
            "MILTON",
            "RAUL",
            "BEN",
            "CHESTER",
            "CECIL",
            "DUANE",
            "FRANKLIN",
            "ANDRE",
            "ELMER",
            "BRAD",
            "GABRIEL",
            "RON",
            "MITCHELL",
            "ROLAND",
            "ARNOLD",
            "HARVEY",
            "JARED",
            "ADRIAN",
            "KARL",
            "CORY",
            "CLAUDE",
            "ERIK",
            "DARRYL",
            "JAMIE",
            "NEIL",
            "JESSIE",
            "CHRISTIAN",
            "JAVIER",
            "FERNANDO",
            "CLINTON",
            "TED",
            "MATHEW",
            "TYRONE",
            "DARREN",
            "LONNIE",
            "LANCE",
            "CODY",
            "JULIO",
            "KELLY",
            "KURT",
            "ALLAN",
            "NELSON",
            "GUY",
            "CLAYTON",
            "HUGH",
            "MAX",
            "DWAYNE",
            "DWIGHT",
            "ARMANDO",
            "FELIX",
            "JIMMIE",
            "EVERETT",
            "JORDAN",
            "IAN",
            "WALLACE",
            "KEN",
            "BOB",
            "JAIME",
            "CASEY",
            "ALFREDO",
            "ALBERTO",
            "DAVE",
            "IVAN",
            "JOHNNIE",
            "SIDNEY",
            "BYRON",
            "JULIAN",
            "ISAAC",
            "MORRIS",
            "CLIFTON",
            "WILLARD",
            "DARYL",
            "ROSS",
            "VIRGIL",
            "ANDY",
            "MARSHALL",
            "SALVADOR",
            "PERRY",
            "KIRK",
            "SERGIO",
            "MARION",
            "TRACY",
            "SETH",
            "KENT",
            "TERRANCE",
            "RENE",
            "EDUARDO",
            "TERRENCE",
            "ENRIQUE",
            "FREDDIE",
            "WADE",
            "AUSTIN",
            "STUART",
            "FREDRICK",
            "ARTURO",
            "ALEJANDRO",
            "JACKIE",
            "JOEY",
            "NICK",
            "LUTHER",
            "WENDELL",
            "JEREMIAH",
            "EVAN",
            "JULIUS",
            "DANA",
            "DONNIE",
            "OTIS",
            "SHANNON",
            "TREVOR",
            "OLIVER",
            "LUKE",
            "HOMER",
            "GERARD",
            "DOUG",
            "KENNY",
            "HUBERT",
            "ANGELO",
            "SHAUN",
            "LYLE",
            "MATT",
            "LYNN",
            "ALFONSO",
            "ORLANDO",
            "REX",
            "CARLTON",
            "ERNESTO",
            "CAMERON",
            "NEAL",
            "PABLO",
            "LORENZO",
            "OMAR",
            "WILBUR",
            "BLAKE",
            "GRANT",
            "HORACE",
            "RODERICK",
            "KERRY",
            "ABRAHAM",
            "WILLIS",
            "RICKEY",
            "JEAN",
            "IRA",
            "ANDRES",
            "CESAR",
            "JOHNATHAN",
            "MALCOLM",
            "RUDOLPH",
            "DAMON",
            "KELVIN",
            "RUDY",
            "PRESTON",
            "ALTON",
            "ARCHIE",
            "MARCO",
            "WM",
            "PETE",
            "RANDOLPH",
            "GARRY",
            "GEOFFREY",
            "JONATHON",
            "FELIPE",
            "BENNIE",
            "GERARDO",
            "ED",
            "DOMINIC",
            "ROBIN",
            "LOREN",
            "DELBERT",
            "COLIN",
            "GUILLERMO",
            "EARNEST",
            "LUCAS",
            "BENNY",
            "NOEL",
            "SPENCER",
            "RODOLFO",
            "MYRON",
            "EDMUND",
            "GARRETT",
            "SALVATORE",
            "CEDRIC",
            "LOWELL",
            "GREGG",
            "SHERMAN",
            "WILSON",
            "DEVIN",
            "SYLVESTER",
            "KIM",
            "ROOSEVELT",
            "ISRAEL",
            "JERMAINE",
            "FORREST",
            "WILBERT",
            "LELAND",
            "SIMON",
            "GUADALUPE",
            "CLARK",
            "IRVING",
            "CARROLL",
            "BRYANT",
            "OWEN",
            "RUFUS",
            "WOODROW",
            "SAMMY",
            "KRISTOPHER",
            "MACK",
            "LEVI",
            "MARCOS",
            "GUSTAVO",
            "JAKE",
            "LIONEL",
            "MARTY",
            "TAYLOR",
            "ELLIS",
            "DALLAS",
            "GILBERTO",
            "CLINT",
            "NICOLAS",
            "LAURENCE",
            "ISMAEL",
            "ORVILLE",
            "DREW",
            "JODY",
            "ERVIN",
            "DEWEY",
            "AL",
            "WILFRED",
            "JOSH",
            "HUGO",
            "IGNACIO",
            "CALEB",
            "TOMAS",
            "SHELDON",
            "ERICK",
            "FRANKIE",
            "STEWART",
            "DOYLE",
            "DARREL",
            "ROGELIO",
            "TERENCE",
            "SANTIAGO",
            "ALONZO",
            "ELIAS",
            "BERT",
            "ELBERT",
            "RAMIRO",
            "CONRAD",
            "PAT",
            "NOAH",
            "GRADY",
            "PHIL",
            "CORNELIUS",
            "LAMAR",
            "ROLANDO",
            "CLAY",
            "PERCY",
            "DEXTER",
            "BRADFORD",
            "MERLE",
            "DARIN",
            "AMOS",
            "TERRELL",
            "MOSES",
            "IRVIN",
            "SAUL",
            "ROMAN",
            "DARNELL",
            "RANDAL",
            "TOMMIE",
            "TIMMY",
            "DARRIN",
            "WINSTON",
            "BRENDAN",
            "TOBY",
            "VAN",
            "ABEL",
            "DOMINICK",
            "BOYD",
            "COURTNEY",
            "JAN",
            "EMILIO",
            "ELIJAH",
            "CARY",
            "DOMINGO",
            "SANTOS",
            "AUBREY",
            "EMMETT",
            "MARLON",
            "EMANUEL",
            "JERALD",
            "EDMOND",
            "EMIL",
            "DEWAYNE",
            "WILL",
            "OTTO",
            "TEDDY",
            "REYNALDO",
            "BRET",
            "MORGAN",
            "JESS",
            "TRENT",
            "HUMBERTO",
            "EMMANUEL",
            "STEPHAN",
            "LOUIE",
            "VICENTE",
            "LAMONT",
            "STACY",
            "GARLAND",
            "MILES",
            "MICAH",
            "EFRAIN",
            "BILLIE",
            "LOGAN",
            "HEATH",
            "RODGER",
            "HARLEY",
            "DEMETRIUS",
            "ETHAN",
            "ELDON",
            "ROCKY",
            "PIERRE",
            "JUNIOR",
            "FREDDY",
            "ELI",
            "BRYCE",
            "ANTOINE",
            "ROBBIE",
            "KENDALL",
            "ROYCE",
            "STERLING",
            "MICKEY",
            "CHASE",
            "GROVER",
            "ELTON",
            "CLEVELAND",
            "DYLAN",
            "CHUCK",
            "DAMIAN",
            "REUBEN",
            "STAN",
            "AUGUST",
            "LEONARDO",
            "JASPER",
            "RUSSEL",
            "ERWIN",
            "BENITO",
            "HANS",
            "MONTE",
            "BLAINE",
            "ERNIE",
            "CURT",
            "QUENTIN",
            "AGUSTIN",
            "MURRAY",
            "JAMAL",
            "DEVON",
            "ADOLFO",
            "HARRISON",
            "TYSON",
            "BURTON",
            "BRADY",
            "ELLIOTT",
            "WILFREDO",
            "BART",
            "JARROD",
            "VANCE",
            "DENIS",
            "DAMIEN",
            "JOAQUIN",
            "HARLAN",
            "DESMOND",
            "ELLIOT",
            "DARWIN",
            "ASHLEY",
            "GREGORIO",
            "BUDDY",
            "XAVIER",
            "KERMIT",
            "ROSCOE",
            "ESTEBAN",
            "ANTON",
            "SOLOMON",
            "SCOTTY",
            "NORBERT",
            "ELVIN",
            "WILLIAMS",
            "NOLAN",
            "CAREY",
            "ROD",
            "QUINTON",
            "HAL",
            "BRAIN",
            "ROB",
            "ELWOOD",
            "KENDRICK",
            "DARIUS",
            "MOISES",
            "SON",
            "MARLIN",
            "FIDEL",
            "THADDEUS",
            "CLIFF",
            "MARCEL",
            "ALI",
            "JACKSON",
            "RAPHAEL",
            "BRYON",
            "ARMAND",
            "ALVARO",
            "JEFFRY",
            "DANE",
            "JOESPH",
            "THURMAN",
            "NED",
            "SAMMIE",
            "RUSTY",
            "MICHEL",
            "MONTY",
            "RORY",
            "FABIAN",
            "REGGIE",
            "MASON",
            "GRAHAM",
            "KRIS",
            "ISAIAH",
            "VAUGHN",
            "GUS",
            "AVERY",
            "LOYD",
            "DIEGO",
            "ALEXIS",
            "ADOLPH",
            "NORRIS",
            "MILLARD",
            "ROCCO",
            "GONZALO",
            "DERICK",
            "RODRIGO",
            "GERRY",
            "STACEY",
            "CARMEN",
            "WILEY",
            "RIGOBERTO",
            "ALPHONSO",
            "TY",
            "SHELBY",
            "RICKIE",
            "NOE",
            "VERN",
            "BOBBIE",
            "REED",
            "JEFFERSON",
            "ELVIS",
            "BERNARDO",
            "MAURICIO",
            "HIRAM",
            "DONOVAN",
            "BASIL",
            "RILEY",
            "OLLIE",
            "NICKOLAS",
            "MAYNARD",
            "SCOT",
            "VINCE",
            "QUINCY",
            "EDDY",
            "SEBASTIAN",
            "FEDERICO",
            "ULYSSES",
            "HERIBERTO",
            "DONNELL",
            "COLE",
            "DENNY",
            "DAVIS",
            "GAVIN",
            "EMERY",
            "WARD",
            "ROMEO",
            "JAYSON",
            "DION",
            "DANTE",
            "CLEMENT",
            "COY",
            "ODELL",
            "MAXWELL",
            "JARVIS",
            "BRUNO",
            "ISSAC",
            "MARY",
            "DUDLEY",
            "BROCK",
            "SANFORD",
            "COLBY",
            "CARMELO",
            "BARNEY",
            "NESTOR",
            "HOLLIS",
            "STEFAN",
            "DONNY",
            "ART",
            "LINWOOD",
            "BEAU",
            "WELDON",
            "GALEN",
            "ISIDRO",
            "TRUMAN",
            "DELMAR",
            "JOHNATHON",
            "SILAS",
            "FREDERIC",
            "DICK",
            "KIRBY",
            "IRWIN",
            "CRUZ",
            "MERLIN",
            "MERRILL",
            "CHARLEY",
            "MARCELINO",
            "LANE",
            "HARRIS",
            "CLEO",
            "CARLO",
            "TRENTON",
            "KURTIS",
            "HUNTER",
            "AURELIO",
            "WINFRED",
            "VITO",
            "COLLIN",
            "DENVER",
            "CARTER",
            "LEONEL",
            "EMORY",
            "PASQUALE",
            "MOHAMMAD",
            "MARIANO",
            "DANIAL",
            "BLAIR",
            "LANDON",
            "DIRK",
            "BRANDEN",
            "ADAN",
            "NUMBERS",
            "CLAIR",
            "BUFORD",
            "GERMAN",
            "BERNIE",
            "WILMER",
            "JOAN",
            "EMERSON",
            "ZACHERY",
            "FLETCHER",
            "JACQUES",
            "ERROL",
            "DALTON",
            "MONROE",
            "JOSUE",
            "DOMINIQUE",
            "EDWARDO",
            "BOOKER",
            "WILFORD",
            "SONNY",
            "SHELTON",
            "CARSON",
            "THERON",
            "RAYMUNDO",
            "DAREN",
            "TRISTAN",
            "HOUSTON",
            "ROBBY",
            "LINCOLN",
            "JAME",
            "GENARO",
            "GALE",
            "BENNETT",
            "OCTAVIO",
            "CORNELL",
            "LAVERNE",
            "HUNG",
            "ARRON",
            "ANTONY",
            "HERSCHEL",
            "ALVA",
            "GIOVANNI",
            "GARTH",
            "CYRUS",
            "CYRIL",
            "RONNY",
            "STEVIE",
            "LON",
            "FREEMAN",
            "ERIN",
            "DUNCAN",
            "KENNITH",
            "CARMINE",
            "AUGUSTINE",
            "YOUNG",
            "ERICH",
            "CHADWICK",
            "WILBURN",
            "RUSS",
            "REID",
            "MYLES",
            "ANDERSON",
            "MORTON",
            "JONAS",
            "FOREST",
            "MITCHEL",
            "MERVIN",
            "ZANE",
            "RICH",
            "JAMEL",
            "LAZARO",
            "ALPHONSE",
            "RANDELL",
            "MAJOR",
            "JOHNIE",
            "JARRETT",
            "BROOKS",
            "ARIEL",
            "ABDUL",
            "DUSTY",
            "LUCIANO",
            "LINDSEY",
            "TRACEY",
            "SEYMOUR",
            "SCOTTIE",
            "EUGENIO",
            "MOHAMMED",
            "SANDY",
            "VALENTIN",
            "CHANCE",
            "ARNULFO",
            "LUCIEN",
            "FERDINAND",
            "THAD",
            "EZRA",
            "SYDNEY",
            "ALDO",
            "RUBIN",
            "ROYAL",
            "MITCH",
            "EARLE",
            "ABE",
            "WYATT",
            "MARQUIS",
            "LANNY",
            "KAREEM",
            "JAMAR",
            "BORIS",
            "ISIAH",
            "EMILE",
            "ELMO",
            "ARON",
            "LEOPOLDO",
            "EVERETTE",
            "JOSEF",
            "GAIL",
            "ELOY",
            "DORIAN",
            "RODRICK",
            "REINALDO",
            "LUCIO",
            "JERROD",
            "WESTON",
            "HERSHEL",
            "BARTON",
            "PARKER",
            "LEMUEL",
            "LAVERN",
            "BURT",
            "JULES",
            "GIL",
            "ELISEO",
            "AHMAD",
            "NIGEL",
            "EFREN",
            "ANTWAN",
            "ALDEN",
            "MARGARITO",
            "COLEMAN",
            "REFUGIO",
            "DINO",
            "OSVALDO",
            "LES",
            "DEANDRE",
            "NORMAND",
            "KIETH",
            "IVORY",
            "ANDREA",
            "TREY",
            "NORBERTO",
            "NAPOLEON",
            "JEROLD",
            "FRITZ",
            "ROSENDO",
            "MILFORD",
            "SANG",
            "DEON",
            "CHRISTOPER",
            "ALFONZO",
            "LYMAN",
            "JOSIAH",
            "BRANT",
            "WILTON",
            "RICO",
            "JAMAAL",
            "DEWITT",
            "CAROL",
            "BRENTON",
            "YONG",
            "OLIN",
            "FOSTER",
            "FAUSTINO",
            "CLAUDIO",
            "JUDSON",
            "GINO",
            "EDGARDO",
            "BERRY",
            "ALEC",
            "TANNER",
            "JARRED",
            "DONN",
            "TRINIDAD",
            "TAD",
            "SHIRLEY",
            "PRINCE",
            "PORFIRIO",
            "ODIS",
            "MARIA",
            "LENARD",
            "CHAUNCEY",
            "CHANG",
            "TOD",
            "MEL",
            "MARCELO",
            "KORY",
            "AUGUSTUS",
            "KEVEN",
            "HILARIO",
            "BUD",
            "SAL",
            "ROSARIO",
            "ORVAL",
            "MAURO",
            "DANNIE",
            "ZACHARIAH",
            "OLEN",
            "ANIBAL",
            "MILO",
            "JED",
            "FRANCES",
            "THANH",
            "DILLON",
            "AMADO",
            "NEWTON",
            "CONNIE",
            "LENNY",
            "TORY",
            "RICHIE",
            "LUPE",
            "HORACIO",
            "BRICE",
            "MOHAMED",
            "DELMER",
            "DARIO",
            "REYES",
            "DEE",
            "MAC",
            "JONAH",
            "JERROLD",
            "ROBT",
            "HANK",
            "SUNG",
            "RUPERT",
            "ROLLAND",
            "KENTON",
            "DAMION",
            "CHI",
            "ANTONE",
            "WALDO",
            "FREDRIC",
            "BRADLY",
            "QUINN",
            "KIP",
            "BURL",
            "WALKER",
            "TYREE",
            "JEFFEREY",
            "AHMED",
            "WILLY",
            "STANFORD",
            "OREN",
            "NOBLE",
            "MOSHE",
            "MIKEL",
            "ENOCH",
            "BRENDON",
            "QUINTIN",
            "JAMISON",
            "FLORENCIO",
            "DARRICK",
            "TOBIAS",
            "MINH",
            "HASSAN",
            "GIUSEPPE",
            "DEMARCUS",
            "CLETUS",
            "TYRELL",
            "LYNDON",
            "KEENAN",
            "WERNER",
            "THEO",
            "GERALDO",
            "LOU",
            "COLUMBUS",
            "CHET",
            "BERTRAM",
            "MARKUS",
            "HUEY",
            "HILTON",
            "DWAIN",
            "DONTE",
            "TYRON",
            "OMER",
            "ISAIAS",
            "HIPOLITO",
            "FERMIN",
            "CHUNG",
            "ADALBERTO",
            "VALENTINE",
            "JAMEY",
            "BO",
            "BARRETT",
            "WHITNEY",
            "TEODORO",
            "MCKINLEY",
            "MAXIMO",
            "GARFIELD",
            "SOL",
            "RALEIGH",
            "LAWERENCE",
            "ABRAM",
            "RASHAD",
            "KING",
            "EMMITT",
            "DARON",
            "CHONG",
            "SAMUAL",
            "PARIS",
            "OTHA",
            "MIQUEL",
            "LACY",
            "EUSEBIO",
            "DONG",
            "DOMENIC",
            "DARRON",
            "BUSTER",
            "ANTONIA",
            "WILBER",
            "RENATO",
            "JC",
            "HOYT",
            "HAYWOOD",
            "EZEKIEL",
            "CHAS",
            "FLORENTINO",
            "ELROY",
            "CLEMENTE",
            "ARDEN",
            "NEVILLE",
            "KELLEY",
            "EDISON",
            "DESHAWN",
            "CARROL",
            "SHAYNE",
            "NATHANIAL",
            "JORDON",
            "DANILO",
            "CLAUD",
            "VAL",
            "SHERWOOD",
            "RAYMON",
            "RAYFORD",
            "CRISTOBAL",
            "AMBROSE",
            "TITUS",
            "HYMAN",
            "FELTON",
            "EZEQUIEL",
            "ERASMO",
            "STANTON",
            "LONNY",
            "LEN",
            "IKE",
            "MILAN",
            "LINO",
            "JAROD",
            "HERB",
            "ANDREAS",
            "WALTON",
            "RHETT",
            "PALMER",
            "JUDE",
            "DOUGLASS",
            "CORDELL",
            "OSWALDO",
            "ELLSWORTH",
            "VIRGILIO",
            "TONEY",
            "NATHANAEL",
            "DEL",
            "BRITT",
            "BENEDICT",
            "MOSE",
            "HONG",
            "LEIGH",
            "JOHNSON",
            "ISREAL",
            "GAYLE",
            "GARRET",
            "FAUSTO",
            "ASA",
            "ARLEN",
            "ZACK",
            "WARNER",
            "MODESTO",
            "FRANCESCO",
            "MANUAL",
            "JAE",
            "GAYLORD",
            "GASTON",
            "FILIBERTO",
            "DEANGELO",
            "MICHALE",
            "GRANVILLE",
            "WES",
            "MALIK",
            "ZACKARY",
            "TUAN",
            "NICKY",
            "ELDRIDGE",
            "CRISTOPHER",
            "CORTEZ",
            "ANTIONE",
            "MALCOM",
            "LONG",
            "KOREY",
            "JOSPEH",
            "COLTON",
            "WAYLON",
            "VON",
            "HOSEA",
            "SHAD",
            "SANTO",
            "RUDOLF",
            "ROLF",
            "REY",
            "RENALDO",
            "MARCELLUS",
            "LUCIUS",
            "LESLEY",
            "KRISTOFER",
            "BOYCE",
            "BENTON",
            "MAN",
            "KASEY",
            "JEWELL",
            "HAYDEN",
            "HARLAND",
            "ARNOLDO",
            "RUEBEN",
            "LEANDRO",
            "KRAIG",
            "JERRELL",
            "JEROMY",
            "HOBERT",
            "CEDRICK",
            "ARLIE",
            "WINFORD",
            "WALLY",
            "PATRICIA",
            "LUIGI",
            "KENETH",
            "JACINTO",
            "GRAIG",
            "FRANKLYN",
            "EDMUNDO",
            "SID",
            "PORTER",
            "LEIF",
            "LAUREN",
            "JERAMY",
            "ELISHA",
            "BUCK",
            "WILLIAN",
            "VINCENZO",
            "SHON",
            "MICHAL",
            "LYNWOOD",
            "LINDSAY",
            "JEWEL",
            "JERE",
            "HAI",
            "ELDEN",
            "DORSEY",
            "DARELL",
            "BRODERICK",
            "ALONSO"
        };
    }
}

<?php
session_start();
require_once "connect.php";	
mysqli_report(MYSQLI_REPORT_STRICT);


if(!isset($_SESSION['zalogowany']))
	{
		header('Location: /Loop-Food/Aplikacja/Admin/admin');
		exit();
	}
?>
<!DOCTYPE html>
<html lang="pl">

<head>
        <meta charset="UTF-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
        

        <title>Panel Admina</title>
        <meta name="description" content="Zajmujemy sie dostawa jedzenia." />
        <meta name="keywords" content="dostawa do domu, jedzenie na wynos, aplikacja do jedzenia"/>
        
        <link rel="stylesheet" href="css/bootstrap.min.css">
        <link rel="shortcut icon" href="img/logo.png">
        <link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">
        <link rel="stylesheet" href="style.css" type="text/css" />
        <link rel="stylesheet" href="css/fontello.css" type="text/css" />
</head>

<body>
        <div class="alert alert-success alert-dismissible fade show" style="text-align: center;"role="alert">
            <strong>Witaj!</strong> <?php echo "$_SESSION.$imie" ?> Powodzenia w pracy.
            <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
        </div>
    <header>
    <nav class="navbar navbar-dark bg-dark">
        <a class="navbar-brand" href="panel-sterowania">
        <img src="img/logo.png" width="70" height="50" alt=""></a>
        <nav class="navbar navbar-light navbar-expand-lg">
        <button class="navbar-toggler flex-row-reverse" type="button" data-toggle="collapse" data-target="#mainmenu" aria-controls="mainmenu" aria-expanded="false" aria-label="Przełącznik nawigacji">
				<span class="navbar-toggler-icon"></span>
			</button>
		
			<div class="collapse navbar-collapse" id="mainmenu">
			
				<ul class="navbar-nav mr-auto">
				
                    
                    <li class="nav-item">
						<a class="nav-link" href="#">Zlecenia</a>
                    </li>
                    
					<li class="nav-item">
						<a class="nav-link" href="#">Restauracja</a>
					</li>
                    
                    <li class="nav-item">
						<a class="nav-link" href="#">Dostawca</a>
					</li>
					
					<li class="nav-item">
						<a class="nav-link" href="#">Klient</a>
                    </li>
                    
                    <li class="nav-item">
						<a class="nav-link" href="logout.php">Wyloguj się</a>
					</li>
				
                </ul>
            </div>
    </nav>
    </nav>
    </header>
    <main>
<?php
echo<<<END
    <div id="col-12 container">
        <br /><br />
        <h3 style="margin-left:20px;">Tabela Zlecenia<h3>
        <br /><br />
        <div class="row panel">
            <div class="col-2 id">
            Nr. Zlecenia
            </div>
            <div class="col-2 imie">
            Imie i Nazwisko klienta
            </div>
            <div class="col-2 restauracja">
            Restauracja
            </div>
            <div class="col-2 dostawca">
            Imie i Nazwisko dostawcy
            </div>
            <div class="col-2 koszyk">
            Zamowienie
            </div>
            <div class="col-2 dodaj">
            Zmień / Usuń
            </div>
        </div>
        
    </div> 
END;
?> 
    <main>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="js/bootstrap.min.js"></script>

</body>
</html>
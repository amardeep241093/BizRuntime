<?php
if(isset $_GET['x']) && (!empty $_GET['x']))
{
	$x = json_encode($_GET['x']);

	echo $x -> Name . '<br/>';
	echo $x -> Name[2] .'< br/>';
	echo $x -> Records[2] -> city .'< br/>';
}





?>
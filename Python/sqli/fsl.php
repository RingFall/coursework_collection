<?php
error_reporting(E_ALL ^ E_DEPRECATED);
if(isset($_GET["id"])){
    $con = mysql_connect("127.0.0.1","root","lxz");
    if (!$con)
    {
        die('Could not connect: ' . mysql_error());
    }
    mysql_select_db("rfdb",$con);
    $querry = "select * from rf where id = " . $_GET['id'];
    var_dump($querry);
    $sql = mysql_query($querry,$con);
    //var_dump($sql);
    if(!$sql)
    {
        die('<p>error:'.mysql_error().'</p>');
    }
    //$result = mysql_fetch_array($sql);

    echo "<table class='itable' border='1' cellspacing='0' width='300px' height='150'>";
    echo "<tr>";
    echo "<td>id</td>";
    echo "<td>username</td>";
    echo "</tr>";
    //遍历查询结果
    while ($result = mysql_fetch_array($sql)) {
	    echo "<tr>";
	    echo "<td>" . $result[0] . "</td>";
	    echo "<td>" . $result[1] . "</td>";
	    echo "</tr>";
	}
}
?>
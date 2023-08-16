<?php include 'relations.php';
include('includes/connection.php');
include('functions/common_functions.php');
global $con;
$ip = get_ip_address();
?>

<body>

    <?php include('navigation.php');
    ?>
    <div class="container text-center">
        <?php
        if (isset($_SESSION['user_name'])) {
            echo '<h2 class="text-center mb-5 shadow-sm p-3" style="color: gray;">Welcome ' . $_SESSION['user_name'] . ' </h2>';
            
        } else {
            echo '<h2 class="text-center mb-5 shadow-sm p-3" style="color: gray;">Welcome guest </h2>';
            echo
                '
                <div class="mx-2">
                <a href="login.php"> <button class="btn btn-success">Login</button></a>
                <a href="signup.php"><button class="btn btn-primary">Sign Up</button></a>
            </div>
                ';
        }

        ?>
    </div>
    <?php
    include('footer.php');
    ?>
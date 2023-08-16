<?php
include('includes/connection.php');
include('functions/common_functions.php');
?>
<?php include 'relations.php' ?>

<body>
    <?php
    if (!file_exists('navigation.php')) {
        include('navigation.php');
    } ?>
    <div class="row px-1">
        <div class="col md-2">
            <div class="row">
                <?php
                if (!isset($_SESSION['user_name'])) {
                    include('login.php');
                } 
                else {
                    include('payment.php');
                }
                ?>
            </div>
        </div>
    </div>
    <?php
    if (!file_exists('footer.php')) {
        include('footer.php');
    } ?>
</body>
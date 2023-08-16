<?php include 'relations.php';
include('includes/connection.php');
include('functions/common_functions.php');
$ip = get_ip_address();
?>

<?php include('navigation.php'); ?>
<?php
global $con;
$ip=get_ip_address();
$select_query="select * from `user_info` where user_ip='$ip'";
$result_select=mysqli_query($con,$select_query);
$run_query=mysqli_fetch_array($result_select);
$user_id=$run_query['user_id'];

?>
<div class="container my-4">
    <h2 class="text-center text-warning">Payment options</h2>
    <div class="row text-center">
        <div class="col-md-6 border">
            <a href="" target="_blank">
                <h2 class="text-center text-warning">Online Payment</h2>
                <img src="about images/payment.png" alt="">
        </div></a>
        <div class="col-md-6 border">
            <a href="order.php?user_id=<?php echo $user_id?>">
                <h2 class="text-center text-warning">Cash on Delevery</h2>
                <img src="about images/cod.png" alt="">
            </a>
        </div>
    </div>
</div>
<?php
include('footer.php');
?>
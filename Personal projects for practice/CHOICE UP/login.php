<?php include 'relations.php';
include('includes/connection.php');
include('functions/common_functions.php');
$ip = get_ip_address();
?>
<body>
    
<?php include ('navigation.php');?>
<div class="container-fluid my-3">
    <h2 class="text-center text-warning">Login</h2>
    <div class="row d-flex align-items-center justify-content-center">
        <div class="col-lg-8 col-xl-6">
            <form action="" method="post">
                <div class="form-outline">
                    <label for="user_email" class="form-label">User Email*</label>
                    <input type="email" id="useremail" placeholder="Enter Your Email" class="form-control"
                        name="user_email" required="Required">
                </div>
                <div class="form-outline">
                    <label for="user_password" class="form-label">Password*</label>
                    <input type="text" id="userpassowrd" placeholder="Enter your password" class="form-control"
                        name="user_password">
                </div>
                <div class="text-center my-2 ">
                    <input type="submit" value="Login" name="login" class="btn btn-success me-auto">
                    <p>New user?<button class="btn text-warning"><a href="signup.php"> Sign Up</button> </p></a>
                    <button class="btn text-warning "><a href="home.php">Back to home</button></a>
                </div>
            </form>
        </div>
    </div>
</div>
<?php
if (isset($_POST['login'])) {
    $user_email = $_POST['user_email'];
    $user_password = $_POST['user_password'];
    $select_query = "select * from `user_info` where  user_email='$user_email'";
    $result_select = mysqli_query($con, $select_query);
    $row_count = mysqli_num_rows($result_select);
    $row_data = mysqli_fetch_assoc($result_select);

    $select_cart_items = "select * from `cart_details` where ip_address='$ip'";
    $result_cart = mysqli_query($con, $select_cart_items);
    $count_cart = mysqli_num_rows($result_cart);
    if ($row_count > 0) {
        if (password_verify($user_password, $row_data['user_password'])) {
            $_SESSION['user_name'] = $row_data['user_name'];
            if ($row_count == 1 && $count_cart) {
                $_SESSION['user_name'] = $row_data['user_name'];
                $user_id=$row_data['user_id'];
                $_SESSION['user_id'] = $row_data['user_id'];
                echo "<script>alert('Login Success full $user_id')</script>";
                echo "<script> location.href='payment.php'; </script>";
            } else {
                $_SESSION['user_name'] = $row_data['user_name'];
                $user_id=$row_data['user_id'];
                $_SESSION['user_id'] = $row_data['user_id'];
                echo "<script>alert('Login Success full ')</script>";
                echo "<script> location.href='payment.php'; </script>";
            }

        } else {
            echo "<script>alert('Invalid User name or password')</script>";
        }
    } else {
        echo "<script>alert('Invalid User name or password')</script>";
    }
}
if (!file_exists('footer.php')) {
    include 'footer.php';
}

?>
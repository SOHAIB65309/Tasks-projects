<?php include 'relations.php';
include('includes/connection.php');
include('functions/common_functions.php');
global $con;
?>
<?php
    include 'navigation.php';

?>

<div class="container-fluid my-3">
    <h2 class="text-center text-warning">Sign Up</h2>
    <div class="row d-flex align-items-center justify-content-center">
        <div class="col-lg-8 col-xl-6">
            <form action="" method="post">
                <div class="form-outline">
                    <label for="user_name" class="form-label">User Name*</label>
                    <input type="text" id="username" placeholder="Enter Your Name" class="form-control" name="user_name"
                        required="Required" autocomplete="off">
                </div>
                <div class="form-outline">
                    <label for="user_Email" class="form-label">User Email*</label>
                    <input type="email" id="useremail" placeholder="Enter Your Email" class="form-control"
                        name="user_email" required="Required">
                </div>
                <div class="form-outline">
                    <label for="user_address" class="form-label">Address*</label>
                    <input type="text" id="useraddress" placeholder="Enter Your Address" class="form-control"
                        name="user_address" required="Required">
                </div>
                <div class="form-outline">
                    <label for="user_address" class="form-label">Phone Number*</label>
                    <input type="number" id="userphone" placeholder="Enter Your Phone Number" class="form-control"
                        name="user_phone" required="Required">
                </div>
                <div class="form-outline">
                    <label for="user_password" class="form-label">Password*</label>
                    <input type="text" id="userpassowrd" placeholder="Set your Password for login" class="form-control"
                        name="user_password" required="Required">
                </div>
                <div class="form-outline">
                    <label for="confrirmpassword" class="form-label">Confirm Password*</label>
                    <input type="text" id="confirmpassword" placeholder="Confirm Password" class="form-control"
                        name="user_confirm_password" required="Required">
                </div>
                <div class="text-center my-2 ">
                    <input type="submit" value="Sign Up" name="signup" class="btn btn-success me-auto">
                    <p>Already have an account?<button class="btn text-warning"><a href="login.php">Login</button> </p>
                    </a>
                    <button class="btn text-warning"><a href="home.php">Back to home</button></a>
                </div>
            </form>
        </div>
    </div>
</div>
<?php
if (isset($_POST['signup'])) {
    $user_name = $_POST['user_name'];
    $user_email = $_POST['user_email'];
    $user_address = $_POST['user_address'];
    $user_phone = $_POST['user_phone'];
    $user_password = $_POST['user_password'];
    $user_confirm_password = $_POST['user_confirm_password'];
    $hash_password=password_hash($user_password,PASSWORD_DEFAULT);
    $ip = get_ip_address();
    $select_querry = "select * from `user_info` where user_email= '$user_email'";
    $result_select = mysqli_query($con, $select_querry);
    $row_count = mysqli_num_rows($result_select);
    if ($row_count > 0) {
        echo "<script>alert('This Email is already registered Login to continue')</script>";
                echo "<script> location.href='login.php'; </script>";

    } else {
        if ($user_password == $user_confirm_password && $user_name != '' && $user_email != '' && $user_address != '' && $user_password != '') {
            $insert_query = "INSERT INTO `user_info` (user_name, user_ip, user_email, user_phone_num, user_address, user_password) VALUES ('$user_name', '$ip', '$user_email', '$user_phone', '$user_address', '$hash_password')";
            $result_query = mysqli_query($con, $insert_query);

            if ($result_query) {

                $select_cart_items="select * from `cart_details` where ip_address='$ip'";
                $result_cart=mysqli_query($con,$select_cart_items);
                $count_cart=mysqli_num_rows($result_cart);
                if($cart_count>0)
                {
                $_SESSION['user_name']=$ussr_name;
                echo "<script>alert('You have items in your cart')</script>";
                echo "<script> location.href='checkout.php'; </script>";
                }
                else{
                echo "<script>alert('Sign Up Successful')</script>";
                echo "<script> location.href='login.php'; </script>";
            }
            }
        }
    }
}

    include 'footer.php';

?>
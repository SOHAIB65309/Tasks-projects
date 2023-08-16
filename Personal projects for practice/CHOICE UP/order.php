<?php include 'relations.php';
include('includes/connection.php');
include('functions/common_functions.php');
global $con;
$ip = get_ip_address();
?>

<body>

    <?php include('navigation.php');
    ?>
    <div class="container">
        <div>
            <h2 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">Review order</h2>
        </div>
        <div>
            <h3 class="text-center mb-5 shadow-sm p-3" style="color: grey ">Total Amount/-
                <?php get_total_cart_price() ?>
            </h3>
        </div>
    </div>
    <?php
    $select_cart = "select * from `cart_details` where ip_address='$ip'";
    $result_cart = mysqli_query($con, $select_cart);
    $num_count = mysqli_num_rows($result_cart);
    if ($num_count > 0) {
        echo '<table class="table table-bordered ">
                 <thead class="bg-warning">
                     <tr class=" text-center ">
                         <th>Select</th>
                         <th>Product Image</th>
                         <th>Product Name</th>
                         <th>Colour</th>
                         <th>Size</th>
                         <th>Quantity</th>
                         <th>Total Price</th>
                     </tr>
                 </thead>
                 <tbody class="table table-bordered mt-3 shadow-sm p-3 ">';
        while ($cart_row = mysqli_fetch_assoc($result_cart)) {
            $product_id = $cart_row['product_id'];
            $color_name = $cart_row['colour_name'];
            $product_size = $cart_row['product_size'];
            $product_qty = $cart_row['total_qty'];
            $get_productname = "select * from `products` where product_id= $product_id";
            $result_product = mysqli_query($con, $get_productname);
            $product_row = mysqli_fetch_assoc($result_product);
            $product_tittle = $product_row['product_tittle'];
            $product_image = $product_row['product_image1'];
            $get_attributes = "select * from `productattributes` where product_id=$product_id and color='$color_name' and size = '$product_size'";
            $result_attributes = mysqli_query($con, $get_attributes);
            $attribute_row = mysqli_fetch_assoc($result_attributes);
            $price = $attribute_row['price'];
            $total_amount = $product_qty * $price;
            echo
                "
 <tr class='bg-light text-secondary text-center'>
 <td><input  type='checkbox' name='checkbox[]' value='$product_id' ></td>
 <td> <img src='./Admin_area/images/$product_image' class='card-img-top' style='height:100px' alt='...'></td>
                             <td>$product_tittle</td>
                             <td>$color_name</td>
                 <td>$product_size</td>
                 <td>$product_qty</td>
                 <td>$total_amount</td>
                          </tr>   ";
        }
        echo '            </tbody>
             </table>


         <div class="container d-flex ">
         <div class="text-center p-2">
         <form action="" method="POST">
         <input type="submit" value="Confirm Order" name="confirm_order" class="btn btn-success">
         </form>
     </div>
         <div class="text-center p-2">
         <a href="checkout.php"><button type="button"  class="btn btn-warning  ">Edit cart</button></a>
         </div>           
         <div class="text-center">
         <a href="featured-product.php"><button type="button"  class="btn btn-primary mt-2  ">Continue Shopping?</button></a>
         </div></div>"';
    } ?>
    <?php
    if (isset($_GET['user_id'])) {
        $user_id = $_GET['user_id'];
        if (isset($_POST['confirm_order'])) {
        
        $total_price = 0;
        $total_qty = 0;
        $total_products = 0;
        $select_cart = "select * from `cart_details` where ip_address='$ip'";
        $result_cart = mysqli_query($con, $select_cart);
        $invoice_number = mt_rand();
        $status = 'pending';
        while ($cart_row = mysqli_fetch_assoc($result_cart)) {
            $product_id = $cart_row['product_id'];
            $color_name = $cart_row['colour_name'];
            $product_size = $cart_row['product_size'];
            $product_qty = $cart_row['total_qty'];
            $get_attributes = "select * from `productattributes` where product_id=$product_id and color='$color_name' and size = '$product_size'";
            $result_attributes = mysqli_query($con, $get_attributes);
            $attribute_row = mysqli_fetch_assoc($result_attributes);
            $price = $attribute_row['price'];
            $total_qty += $product_qty;
            $total_amount = $product_qty * $price;
            $total_price += $total_amount;
            $total_products++;
        }
        $insert_query = "INSERT INTO `user_orders` (user_id, total_qty, amount_due, invoice_number, total_products, order_date, order_status)
                VALUES ('$user_id', '$total_qty', '$total_price', '$invoice_number', '$total_products', NOW(), '$status')";
            $result_insert = mysqli_query($con, $insert_query);

            // Get the auto-generated order_id
            $order_id = mysqli_insert_id($con);

            // Insert product details into "order_details" table
            mysqli_data_seek($result_cart, 0); // Reset the result pointer
            while ($cart_row = mysqli_fetch_assoc($result_cart)) {
                $product_id = $cart_row['product_id'];
                $color_name = $cart_row['colour_name'];
                $product_size = $cart_row['product_size'];
$select_product_query="select * from `products` where product_id=$product_id";
$res_sel=mysqli_query($con,$select_product_query);
$product_row=mysqli_fetch_assoc($res_sel);
$product_name=$product_row['product_tittle'];
                // Insert the product details into "order_details" table
                $insert_order_details = "INSERT INTO `order_details` (order_id,invoice_num, product_name, color, size)
                    VALUES ('$order_id',$invoice_number,'$product_name', '$color_name', '$product_size')";
                $result_order_details = mysqli_query($con, $insert_order_details);
                $delete_query = "DELETE FROM `cart_details` WHERE ip_address = '$ip'";
$result_delete = mysqli_query($con, $delete_query);
            }
            if ($result_insert && $result_order_details && $result_delete) {
                $delete_query="";
                echo "<script>alert('Order Confirmed')</script>";
                echo "<script>location.href='user_profile.php?$user_id';</script>";
            } else {
                echo "<script>alert('Failed to confirm order. Please try again.')</script>";
            }
        }
    }
    ?>

    <?php
    include('footer.php');

    ?>
<?php
include('includes/connection.php');
include('functions/common_functions.php');
?>
<?php include 'relations.php' ?>

<body>
    <?php include 'navigation.php' ?>
    <div class="container">
        <div>
            <h2 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">My Cart</h2>
        </div>
        <div>
            <h3 class="text-center mb-5 shadow-sm p-3" style="color: grey ">Total Amount/-
                <?php get_total_cart_price() ?>
            </h3>
        </div>
    </div>
    <form method="post">

        <?php
        $ip = get_ip_address();
        global $con;
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
                            <th>Delete</th>
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
                    <td><i class='fa-solid fa-trash'><input class='bg-light border-0 text-secondary btn' type='submit' value='Delete Cart'
                    name='delete_cart[$product_id]'></i></td>
                             </tr>   ";
            }
            echo '            </tbody>
                </table>


            <div class="container d-flex ">
            <div class="text-center p-2">
            <input type="submit" value="Delete All" name="delete_all" class="btn btn-danger">
        </div>
            <div class="text-center p-2">
            <a href="checkout.php"><button type="button"  class="btn btn-success  ">Check out</button></a>
            </div>           
            <div class="text-center">
            <a href="featured-product.php"><button type="button"  class="btn btn-primary mt-2  ">Continue Shopping?</button></a>
            </div></div>"';
        } else {
            echo '    <div class="container">
                <div>
                    <h2 class="text-center mb-5 shadow-sm p-3" style="color: red ">Opps your cart is empty</h2>
                </div>
                <div class="text-center">
<a href="featured-product.php"><button type="button"  class="btn btn-primary p-2 my-2">Continue Shopping?</button></a>
</div></div>"
                ';
        }
        ?>


        <?php
        global $con;
        if (isset($_POST['delete_cart'])) {
            $remove_ids = $_POST['delete_cart'];
            if (is_array($remove_ids)) {
                foreach ($remove_ids as $remove_id => $value) {
                    echo $remove_id;
                    $delete_query = "delete from `cart_details` where product_id = $remove_id";
                    $result_delete = mysqli_query($con, $delete_query);
                    if ($result_delete) {
                        echo "<script> location.href='my_cart.php'; </script>";
                    }
                }
            }
        }
        if (isset($_POST['delete_all'])) {
            if (isset($_POST['checkbox']) && is_array($_POST['checkbox'])) {
                $remove_ids = $_POST['checkbox'];
                foreach ($remove_ids as $remove_id) {
                    $delete_query = "delete from `cart_details` where product_id = $remove_id";
                    $result_delete = mysqli_query($con, $delete_query);
                }
                echo "<script> location.href='my_cart.php'; </script>";
            }
        }
        ?>
    </form>
    <?php include 'footer.php' ?>

</body>
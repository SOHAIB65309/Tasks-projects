<?php

include('./includes/connection.php');
if (session_status() == PHP_SESSION_NONE) {
    session_start();
}
//get products from database and and show in main indes
if (!function_exists('getproducts')) {
    function getproducts()
    {
        global $con;
        if (!isset($_GET['catagory'])) {
            $insert_query = "select * from `products`  order by rand() limit 0,12";
            $result_query = mysqli_query($con, $insert_query);
            while ($row = mysqli_fetch_assoc($result_query)) {
                $product_id = $row['product_id'];
                $product_tittle = $row['product_tittle'];
                $product_discription = $row['product_discription'];
                $catagory_id = $row['catagory_id'];
                $product_image1 = $row['product_image1'];
                $product_price = $row['product_price'];
                echo "<div class='col-md-4 mb-2'>
    <div class='card'style='border-radius: 4px;'>
<img class='card-img-top' src='./Admin_area/images/$product_image1'  alt='$product_tittle'>
<div class='card-body'>
<h5 class='card-title' style='color:blue;'>$product_tittle </h5>
<p class='card-text'>$product_discription</p>
<p class='card-text'><small class='text-muted'>Last updated 1 min ago</small></p>
<h5 class='card-title' style='color:grey;'><i>$product_price </i></h5>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-success'>Add to cart</button></a>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-primary'>View more</button></a>
</div>
    </div>
</div>";
            }
        }

    }
}
//show catagory nav bar side
if (!function_exists('getcatagories')) {
function getcatagories()
{
    global $con;
    $select_catagory = "select * from `catagory`";
    $result_select = mysqli_query($con, $select_catagory);
    while ($row_data = mysqli_fetch_assoc($result_select)) {
        $catagory_tittle = $row_data['catagory_tittle'];
        $catagory_id = $row_data['catagory_id'];
        echo "<li class='navbar-item'>
        <a class='nav-link text-light dropdown-item ' href='home.php?catagory=$catagory_id' >$catagory_tittle
        </a>
    </li>";
    }
}}
//side nav bar when click
if (!function_exists('get_unique_catagory')) {
function get_unique_catagory()
{
    global $con;
    if (isset($_GET['catagory'])) {
        $catagory_id = $_GET['catagory'];
        $insert_query = "select * from `products` where catagory_id=$catagory_id order by rand() ";
        $result_query = mysqli_query($con, $insert_query);
        $num_of_rows = mysqli_num_rows($result_query);
        if ($num_of_rows == 0) {
            echo " <div class='container'>
        <div>
            <h2 class='text-center mb-5 shadow-sm p-3' style='color: gray; '>No Items to show</h2>
        </div>
    </div>}";
        }
        while ($row = mysqli_fetch_assoc($result_query)) {
            $product_id = $row['product_id'];
            $product_tittle = $row['product_tittle'];
            $product_discription = $row['product_discription'];
            $catagory_id = $row['catagory_id'];
            $product_image1 = $row['product_image1'];
            $product_price = $row['product_price'];
            echo "<div class='col-md-4 mb-2'>
    <div class='card'style='border-radius: 4px;'>
<img class='card-img-top' src='./Admin_area/images/$product_image1'  alt='$product_tittle'>
<div class='card-body'>
<h5 class='card-title' style='color:blue;'>$product_tittle </h5>
<p class='card-text'>$product_discription</p>
<p class='card-text'><small class='text-muted'>Last updated 1 min ago</small></p>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-success'>Add to cart</button></a>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-primary'>View more</button></a>
</div>
    </div>
</div>";
        }
    }
}

}
if (!function_exists('view_all_products')) {
function view_all_products()
{
    global $con;
    if (!isset($_GET['catagory'])) {
        $insert_query = "select * from `products`  order by rand()";
        $result_query = mysqli_query($con, $insert_query);
        while ($row = mysqli_fetch_assoc($result_query)) {
            $product_id = $row['product_id'];
            $product_tittle = $row['product_tittle'];
            $product_discription = $row['product_discription'];
            $catagory_id = $row['catagory_id'];
            $product_image1 = $row['product_image1'];
            $product_price = $row['product_price'];
            echo "<div class='col-md-4 mb-2'>
    <div class='card'style='border-radius: 4px;'>
<img class='card-img-top' src='./Admin_area/images/$product_image1'  alt='$product_tittle'>
<div class='card-body'>
<h5 class='card-title' style='color:blue;'>$product_tittle </h5>
<p class='card-text'>$product_discription</p>
<p class='card-text'><small class='text-muted'>Last updated 1 min ago</small></p>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-success'>Add to cart</button></a>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-primary'>View more</button></a>
</div>
    </div>
</div>";
        }
    }
}
}
//search Data
if (!function_exists('search_products')) {
function search_products()
{
    global $con;
    if (isset($_GET['search_data_btn'])) {
        $search_data_value = $_GET['search_data'];
        $search_query = "select * from `products` where product_keyword like'%$search_data_value%'  order by rand() ";
        $result_query = mysqli_query($con, $search_query);
        $num_of_rows = mysqli_num_rows($result_query);
        if ($num_of_rows == 0) {
            echo " <div class='container'>
        <div>
            <h2 class='text-center mb-5 shadow-sm p-3' style='color: gray; '>This product not available right now</h2>
        </div>
    </div>}";
        }
        while ($row = mysqli_fetch_assoc($result_query)) {
            $product_id = $row['product_id'];
            $product_tittle = $row['product_tittle'];
            $product_discription = $row['product_discription'];
            $catagory_id = $row['catagory_id'];
            $product_image1 = $row['product_image1'];
            $product_price = $row['product_price'];
            echo "<div class='col-md-4 mb-2'>
    <div class='card'style='border-radius: 4px;'>
<img class='card-img-top' src='./Admin_area/images/$product_image1'  alt='$product_tittle'>
<div class='card-body'>
<h5 class='card-title' style='color:blue;'>$product_tittle </h5>
<p class='card-text'>$product_discription</p>
<p class='card-text'><small class='text-muted'>Last updated 1 min ago</small></p>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-success'>Add to cart</button></a>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-primary'>View more</button></a>
</div>
    </div>
</div>";
        }
    }
}
}
//product details show
if (!function_exists('show_product_details')) {
function show_product_details()
{

    global $con;
    if (isset($_GET['product_id'])) {
        $product_id = $_GET['product_id'];
        if (!isset($_GET['catagory'])) {
            $insert_query = "select * from `products` where product_id=$product_id";
            $result_query = mysqli_query($con, $insert_query);
            while ($row = mysqli_fetch_assoc($result_query)) {
                $product_id = $row['product_id'];
                $product_tittle = $row['product_tittle'];
                $product_discription = $row['product_discription'];
                $catagory_id = $row['catagory_id'];
                $product_image1 = $row['product_image1'];
                $product_image2 = $row['product_image2'];
                $product_image3 = $row['product_image3'];
                $product_price = $row['product_price'];
                $product_id = $row['product_id'];
                $product_tittle = $row['product_tittle'];
                $product_discription = $row['product_discription'];
                $catagory_id = $row['catagory_id'];
                $product_image1 = $row['product_image1'];
                $product_price = $row['product_price'];
                echo "
    <nav style='--bs-breadcrumb-divider: >;' aria-label='breadcrumb'>
    <ol class='breadcrumb'>
        <li class='breadcrumb-item'><a href='home.php' style='text-decoration: none;'>Home</a></li>
        <li class='breadcrumb-item active' aria-current='page'>$product_tittle</li>
    </ol>
</nav>
<div class=container'>
    <div>
        <h2 class='text-center mb-5 shadow-sm p-3' style='color: gray; '>$product_tittle</h2>
    </div>
</div>;
<div id='carouselExampleInterval' class='carousel slide w-50 ms-5 ' style'height:250px' data-bs-ride='carousel'>
    <div class='carousel-inner text-center'>
        <div class='carousel-item active ' data-bs-interval='10000'>
            <img src='./Admin_area/images/$product_image1' class='d-block w-100' alt='...'>
        </div>
        <div class='carousel-item' data-bs-interval='2000'>
            <img src='./Admin_area/images/$product_image2' class='d-block w-100' alt='...'>
        </div>
        <div class='carousel-item'>
            <img src='./Admin_area/images/$product_image3' class='d-block w-100' alt='...'>
        </div>
    </div>
    <button class='carousel-control-prev' type='button' data-bs-target='#carouselExampleInterval'
        data-bs-slide='prev'>
        <span class='carousel-control-prev-icon' aria-hidden='true'></span>
        <span class='visually-hidden'>Previous</span>
    </button>
    <button class='carousel-control-next' type='button' data-bs-target='#carouselExampleInterval'
        data-bs-slide='next'>
        <span class='carousel-control-next-icon' aria-hidden='true'></span>
        <span class='visually-hidden'>Next</span>
    </button>
</div>
<div class=container'>
    <div>
        <h2 class=' mb-2 shadow-sm p-3 ' style='color: gray; '><u> Product Discription</u></h2>
        <h3 class=' mb-2 shadow-sm p-3' style='color: dark; '>$product_discription</h3>
        <h3 class=' mb-2 shadow-sm p-3' style='color: dark; '> <u>Current  Price</u> : <i> $product_price</i></h3>
    </div>
</div>";
                echo
                    '
<body>
    <div class="container mt-5">
        <h1 style="font-family: "Times New Roman", Times, serif;" class="text-center text-bold">Add New Product</h1>
        <form action="" method="POST" enctype="multipart/form-data">
            <div class="form-outline md-4 w-50 m-auto">
                <select name="product_color" class="product_color form-select mt-2" required>
                    <option value="">Select Colour</option>
';
                $select_catagory1 = "SELECT DISTINCT color FROM `productattributes` WHERE product_id = $product_id";
                $result_select1 = mysqli_query($con, $select_catagory1);
                while ($row_data1 = mysqli_fetch_assoc($result_select1)) {
                    $color = $row_data1['color'];
                    echo "<option value='$color'>$color</option>";
                }
                echo
                    '
</select><select name="product_sizes" class="product_sizes form-select mt-2" required>
                    <option value="">Select size</option>';
                $select_sizes = "SELECT DISTINCT size FROM `productattributes` WHERE $product_id";
                $result_sizes = mysqli_query($con, $select_sizes);
                while ($row_data = mysqli_fetch_assoc($result_sizes)) {
                    $size = $row_data['size'];
                    echo "<option value='$size'>$size</option>";
                }
                echo '</select>

<input type="number" name="product_quantity" class="form-control mt-2" placeholder="Quantity" required
    max=10 min=0>
</div>';
                echo "
<ul class='list-unstyled text-center mt-2'>
<li > <button type='submit' class='btn btn-success w-20 btn-xl text-light' name='add_to_cart'>Add to cart</button>
 <a href='.//home.php'><button type='button' class='btn btn-warning w-20 btn-xl text-light'  data-bs-toggle='modal' data-bs-target='#exampleModal'>Back to home </button></a></li>
</ul>
</form></div>";
                if (isset($_POST['add_to_cart'])) {
                    $product_id;
                    $ip = get_ip_address();
                    $color = $_POST['product_color'];
                    $product_size = $_POST['product_sizes'];
                    $product_quantity = $_POST['product_quantity'];
                    $check_data = "select * from `productattributes` where product_id=$product_id and color = '$color' and size = '$product_size'";
                    $result_check = mysqli_query($con, $check_data);
                    if ($row_check = mysqli_fetch_assoc($result_check)) {
                        $qty = $row_check['quantity'];
                        if ($qty >= $product_quantity) {
                            $select_cart = "select * from `cart_details` where product_id=$product_id and ip_address='$ip'";
                            $result_cart_select = mysqli_query($con, $select_cart);
                            if ($row_check = mysqli_fetch_assoc($result_cart_select)) {
                                echo "<script>alert('This item is allready available in your cart')</script>";
                                echo "<script> location.href='view_details.php?product_id=$product_id'; </script>";
                            } else {
                                $insert_cart = "insert into `cart_details`(product_id,ip_address,colour_name,product_size,total_qty) values($product_id,'$ip','$color','$product_size',$product_quantity)";
                                $result_insert = mysqli_query($con, $insert_cart);
                                if ($result_insert) {
                                    echo "<script>alert('Product has been added successfully added in your cart')</script>";
                                    echo "<script> location.href='view_details.php?product_id=$product_id'; </script>";
                                }

                            }
                        }

                    }
                }
                echo "<div class=container'>
    <div>
        <h2 class='text-center mb-5 shadow-sm p-3' style='color: gray; '>Suggested Items</h2>
    </div>
</div>";
                if (!isset($_GET['catagory'])) {
                    $insert_query = "select * from `products`  order by rand() limit 0,12";
                    $result_query = mysqli_query($con, $insert_query);
                    while ($row = mysqli_fetch_assoc($result_query)) {
                        $product_id = $row['product_id'];
                        $product_tittle = $row['product_tittle'];
                        $product_discription = $row['product_discription'];
                        $catagory_id = $row['catagory_id'];
                        $product_image1 = $row['product_image1'];
                        $product_price = $row['product_price'];
                        echo "<div class='col-md-4 mb-2'>
    <div class='card'style='border-radius: 4px;'>
<img class='card-img-top' src='./Admin_area/images/$product_image1'  alt='$product_tittle'>
<div class='card-body'>
<h5 class='card-title' style='color:blue;'>$product_tittle </h5>
<p class='card-text'>$product_discription</p>
<p class='card-text'><small class='text-muted'>Last updated 1 min ago</small></p>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-success'>Add to cart</button></a>
<a href='view_details.php?product_id=$product_id'><button type='button' class='btn btn-primary'>View more</button></a>
</div>
    </div>
</div>
";
                    }
                }
            }
        }
    }
}
}
if (!function_exists('get_ip_address')) {
function get_ip_address()
{


    if (!empty($_SERVER['HTTP_CLIENT_IP'])) {
        $ip = $_SERVER['HTTP_CLIENT_IP'];
    }
    //whether ip is from the proxy  
    elseif (!empty($_SERVER['HTTP_X_FORWARDED_FOR'])) {
        $ip = $_SERVER['HTTP_X_FORWARDED_FOR'];
    }
    //whether ip is from the remote address  
    else {
        $ip = $_SERVER['REMOTE_ADDR'];
    }
    return $ip;
}}
if (!function_exists('cart')) {
function cart()
{

    if (isset($_GET['add_to_cart'])) {
        global $con;
        $ip = get_ip_address();
        $get_product_id = $_GET['add_to_cart'];
        $select_query = "select * from `cart_details` where ip_address ='$ip' and product_id='$get_product_id'";
        $result_query = mysqli_query($con, $select_query);
        $num_of_rows = mysqli_num_rows($result_query);
        if ($num_of_rows > 0) {
            echo "<script> alert('This item is already available in your cart')</script>";
            echo "<script>window.open('home.php','_self')</script>";
        } else {
            $insert_query = "insert into `cart_details`(ip_address,colour_name,product_size,total_qty)";
        }
    }
}}
if (!function_exists('get_cart_items_qty')) {
function get_cart_items_qty()
{
    if (isset($_GET['add_to_cart'])) {
        global $con;
        $ip = get_ip_address();
        $select_query = "select * from `cart_details` where ip_address ='$ip' ";
        $result_query = mysqli_query($con, $select_query);
        $num_of_cart = mysqli_num_rows($result_query);
    } else {
        global $con;
        $ip = get_ip_address();
        $select_query = "select * from `cart_details` where ip_address ='$ip' ";
        $result_query = mysqli_query($con, $select_query);
        $num_of_cart = mysqli_num_rows($result_query);
    }
    echo $num_of_cart;

}
}
if (!function_exists('get_total_cart_price')) {
function get_total_cart_price()
{
    $ip = get_ip_address();
    global $con;
    $total_price = 0;
    $select_cart = "select * from `cart_details` where ip_address='$ip'";
    $result_cart = mysqli_query($con, $select_cart);
    while ($cart_row = mysqli_fetch_assoc($result_cart)) {
        $product_id = $cart_row['product_id'];
        $color_name = $cart_row['colour_name'];
        $product_size = $cart_row['product_size'];
        $product_qty = $cart_row['total_qty'];
        $get_attributes = "select * from `productattributes` where product_id=$product_id and color='$color_name' and size = '$product_size'";
        $result_attributes = mysqli_query($con, $get_attributes);
        $attribute_row = mysqli_fetch_assoc($result_attributes);
        $price = $attribute_row['price'];

        $total_amount = $product_qty * $price;
        $total_price += $total_amount;
    }
    echo $total_price;
}
}
?>
<?php
include('../includes/connection.php');
include('relations.php');
?>

<body>
    <div class="container">
        <div>
            <h2 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">All Products</h2>
        </div>
        <table class="table table-bordered mt-3">
            <thead class="bg-warning">
                <tr class=" text-center">
                    <th>Product Id</th>
                    <th>PRoduct Tittle</th>
                    <th>Catagory Id </th>
                    <th>Product Image</th>
                    <th>Product Attributes </th>
                    <th>Product Price</th>
                    <th>Total Sold</th>
                    <th>Status</th>
                    <th>Edit </th>
                    <th>Delete</th>
                </tr>
            </thead>
            <tbody class="table table-bordered mt-3 shadow-sm p-3 ">
                <?php
                global $con;
                $insert_query = "select * from `products`";
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
                    $product_status =$row['product_status'];
                    echo
                    "
                    <tr class='bg-lightt text-secondary text-center'>
                    <td>$product_id</td>
                    <td>$product_tittle</td>
                    <td>$catagory_id</td>
                    <td> <img class='card-img-top' style='height:100px' src='./images/$product_image1' alt='$product_tittle'></td>
                    <td><a href='add_colours _and_sizes.php?product_id=$product_id & catagory_id=$catagory_id & product_price=$product_price' class='text-info'>Colours & Qty</a></td>
                    <td>$product_price </td>
                    <td>Total sold</td>
                    <td>$product_status</td>
                    <td><a href='edit_product.php?product_id=$product_id' class='text-secondary'><i class='fa-solid fa-pen-to-square'></i></a> Edit</td>
                    <td><a href='#' class='text-secondary'><i class='fa-solid fa-trash'></i></a>Delete</td>
                </tr>
                    ";
                }
                ?>
                
            </tbody>
        </table>
    </div>
</body>
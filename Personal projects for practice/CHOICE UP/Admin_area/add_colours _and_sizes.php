<?php
include('relations.php');
$servername = "localhost";
$username = "root";
$password = "";
$databasename = "choiceup";
$con = mysqli_connect($servername, $username, $password, $databasename);
if (!$con) {
    echo (mysqli_error($con));
}
$product_id = $_GET['product_id'];
$product_catagory = $_GET['catagory_id'];
$product_price = $_GET['product_price'];
if (isset($_POST['insert_attributes'])) {

    $size = $_POST['select_size'];
    $colour = $_POST['select_colour'];
    $product_quantity = $_POST['product_quantity'];

    if ($product_id == '' || $product_catagory == '' || $colour == '' || $size == '' || $product_quantity == '') {
        echo "<script>alert('Please fill the availabe fields')</script>";
    } else {
        $insert_attribute = "INSERT INTO `productattributes` (product_id, catagory_id, color, size, quantity, price)
        VALUES ('$product_id', '$product_catagory', '$colour', '$size', '$product_quantity', '$product_price')";
        $result_query = mysqli_query($con, $insert_attribute);
        if ($result_query) {
            echo "<script>alert('attributes has been added successfully')</script>";
            header("Location: add_colours _and_sizes.php?product_id=$product_id & catagory_id=$product_catagory & product_price=$product_price"); // Replace "your_page.php" with the desired page to redirect
            exit();
        }
    }
}
?>

<body>
    <div class="container">
        <div>
            <h2 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">Manage Products Colors & Quantity</h2>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <!--products--->
            <div class="row">
                <div class="container">
                    <div>
                        <h4 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">Select Colours And size</h4>
                    </div>
                </div>
                <form action="" method="POST">
                    <div class="form outline md-4 w-50 m-auto">
                        <select name="select_colour" id="" class="select_colour form-select mt-2">
                            <option value="">Select Colours </option>
                            <?php
                            global $con;
                            if (!$con) {
                                echo (mysqli_error($con));
                            }
                            $select_colour_combination = "select * from `colours_combination`";
                            $result_select = mysqli_query($con, $select_colour_combination);
                            while ($row_data = mysqli_fetch_assoc($result_select)) {
                                $colour_name = $row_data['colour_name'];
                                $colour_id = $row_data['colour_id'];
                                echo "<option value='$colour_name'>$colour_name</option>";
                            }
                            ?>
                        </select>
                    </div>
                    <div class="form outline md-4 w-50 m-auto">
                        <select name="select_size" id="" class="select_size form-select mt-2">
                            <option value="">Select Size</option>
                            <?php
                            global $con;
                            if (!$con) {
                                echo (mysqli_error($con));
                            }
                            echo 545;
                            $select_size = "select * from `size_combinations`";
                            $result_select = mysqli_query($con, $select_size);
                            while ($row_data = mysqli_fetch_assoc($result_select)) {
                                $size_name = $row_data['size_name'];
                                $size_id = $row_data['size_id'];
                                echo "<option value='$size_name'>$size_name</option>";
                            }
                            ?>
                        </select>
                    </div>
                    <div class="form outline md-4 w-50 m-auto">
                        <label for="product_discription" class="form-label">Quantity availabe*</label>
                        <input type="number" name="product_quantity" id="product_quantity" class="form-control"
                            placeholder="Enter Poduct discription" autocomplete="off">
                    </div>
                    <div class="form outline md-4 w-50 m-auto my-2 text-center">
                        <input class="bg-warning border-0 px-3 btn"  type="submit" value="insert attributes"
                            name="insert_attributes" accept="image/*">
                    </div>
                </form>
            </div>
        </div>
        <!-- Side table -->
        <div class="col-md-8 bg-secondary p-0">
            <div class="container">
                <div>
                    <h4 class="text-center mb-5 shadow-sm p-3 text-light">Availabe Colors and sizes</h4>
                    <table class="table table-bordered ">
                        <thead class="bg-warning">
                            <tr class=" text-center ">
                                <th>Attribute Id</th>
                                <th>Colours</th>
                                <th>Size</th>
                                <th>Quantity </th>
                                <th>Price</th>
                                <th>Edit </th>
                                <th>Delete</th>
                            </tr>
                        </thead>
                        <tbody class="table table-bordered mt-3 shadow-sm p-3 ">
                            <?php
                            global $con;
                            $select_query = "select * from `productattributes` where product_id = $product_id and catagory_id = $product_catagory";
                            $result_query = mysqli_query($con, $select_query);
                            while ($row = mysqli_fetch_assoc($result_query)) {
                                $attribute_id = $row['attribute_id'];
                                $color_name = $row['color'];
                                $color_size = $row['size'];
                                $available_quantity = $row['quantity'];
                                $product_price = $row['price'];
                                echo "
                                <tr class='bg-lightt text-light text-center'>
                                <td>$attribute_id</td>
                                <td>$color_name</td>
                    <td>$color_size</td>
                    <td>$available_quantity/td>
                    <td>$product_price</td>
                    <td><a href='#' class='text-light'><i class='fa-solid fa-pen-to-square'></i></a> Edit</td>
                    <td><a href='#' class='text-light'><i class='fa-solid fa-trash'></i></a>Delete</td>
                                ";

                            }
                            ?>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <?php include 'footer.php' ?>
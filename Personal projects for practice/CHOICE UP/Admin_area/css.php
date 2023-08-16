<?php

$servername="localhost";
$username="root";
$password="";
$databasename="choiceup";
$con=mysqli_connect($servername,$username,$password,$databasename);
if(!$con)
{
    echo(mysqli_error($con));
}
 if (isset($_POST['insert_product'])){ 
 $product_tittle=$_POST['product_tittle'];
 $product_discription=$_POST['product_discription'];
 $product_keyword=$_POST['product_keywords'];
 $product_catagory=$_POST['product_catagories'];
 echo "<script>alert('$product_catagory')</script>";
 $product_price=$_POST['product_price'];
 $product_status='true';
     $file_name1 = $_FILES['image1']['name'];
     $file_tmp1 = $_FILES['image1']['tmp_name'];
     $file_name2 = $_FILES['image2']['name'];
     $file_tmp2 = $_FILES['image2']['tmp_name'];
     $file_name3 = $_FILES['image3']['name'];
     $file_tmp3 = $_FILES['image3']['tmp_name'];

     $file_destination1 = './images/'.$file_name1;
     $file_destination2 = './images/'.$file_name2;
     $file_destination3 = './images/'.$file_name3; 
          if($product_discription==''||$product_keyword==''||$product_catagory=='' 
 ||$product_tittle ==''){  echo "<script>alert('Please fill the availabe fields')</script>";}
 else
 {
     move_uploaded_file($file_tmp1, $file_destination1);
     move_uploaded_file($file_tmp2, $file_destination2);
     move_uploaded_file($file_tmp3, $file_destination3);
     //insert Query
  $insert_products ="insert into `products`(product_tittle,product_discription,product_keyword,catagory_id,product_image1,product_image2,product_image3,
     qty_small,qty_medium,qty_large,	qty_xl,qty_2xl,product_price,product_status) values('$product_tittle','$product_discription','$product_keyword','$product_catagory','$file_name1','$file_name2',
     '$file_name3','$product_price','$product_status')";
     $result_query= mysqli_query($con,$insert_products);
     if($result_query)
     {
         echo"<script>alert('Product has been added successfully')</script>";
                 header("Location:css.php"); // Replace "your_page.php" with the desired page to redirect
        exit();
     }
 }
}
?>

<!doctype html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title> Choice up</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="style.css">

    <!---forn ausome link-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" integrity="sha512-iecdLmaskl7CVkqkXNQ/ZH/XLlvWZOJyj7Yy7tcenmpD1ypASozpmT/E0iPtmFIB46ZmdtAc9eNBvH0H/ZpiBw==" crossorigin="anonymous" referrerpolicy="no-referrer" />

</head>
<body>
<div class="container mt-5">
<h1 style="font-family:'Times New Roman', Times, serif;" class="text-center text-bold" >Add New Product</h1>
        <form action="" method="POST" enctype="multipart/form-data">
            <div class="form outline md-4 w-50 m-auto">
            
                <label for="product_tittle" class="form-label">Product Tittle*</label>
            <input type="text" name="product_tittle" id="product_tittle" class="form-control"
            placeholder="Enter Poduct Tittle" autocomplete="off" >
            </div>
            <div class="form outline md-4 w-50 m-auto">
                <label for="product_discription" class="form-label">Product discription*</label>
            <input type="text" name="product_discription" id="product_discription" class="form-control"
            placeholder="Enter Poduct discription" autocomplete="off" >
            </div>
            <div class="form outline md-4 w-50 m-auto">
                <label for="product_keywords" class="form-label">Product Keywords*</label>
            <input type="text" name="product_keywords" id="product_keywords" class="form-control"
            placeholder="Enter Poduct keywords" autocomplete="off" required >
            </div>
            <div class="form outline md-4 w-50 m-auto">
                <select name="product_catagories" id=""class="product_catagory form-select mt-2" required>
                     <option  value="">Select catagory</option>
                    <?php
    if(!$con)
    {
        echo(mysqli_error($con));
    }
                    $select_catagory="select * from `catagory`";
                    $result_select= mysqli_query($con,$select_catagory);            
            while($row_data=mysqli_fetch_assoc($result_select))
            {
                $catagory_tittle=$row_data['catagory_tittle'];
                $catagory_id=$row_data['catagory_id'];
                echo "<option value='$catagory_id'>$catagory_tittle</option>" ; 
            }
            ?>
                </select>
            <div class="form outline md-4 w-50 m-auto ">
                <label for="image">Choose Image 1*</label>
                <input type="file" name="image1" id="image" class="form-control form-control-file"  accept="image/*">
            </div>
            <div class="form outline md-4 w-50 m-auto">
                <label for="image">Choose Image 2*</label>
                <input type="file" name="image2" id="image" class="form-control form-control-file"  accept="image/*">
            </div>
            <div class="form outline md-4 w-50 m-auto">
                <label for="image">Choose Image 3*</label>
                <input type="file" name="image3" id="image" class="form-control form-control-file"  accept="image/*">
            </div>            
            <!--product Price-->
            <div class="form outline md-4 w-50 m-auto">
                <label for="product_price" class="form-label">Product Price*</label>
            <input type="text" name="product_price" id="product_price" class="form-control"
            placeholder="Enter Poduct Price" autocomplete="off" >
            </div>
            <div class="form outline md-4 w-50 m-auto my-2">
                <input class="bg-info border-0 px-3 btn" type="submit" value="insert product" name="insert_product" accept="image/*">
            </div>
        </form>
</div>
</body>
</html>

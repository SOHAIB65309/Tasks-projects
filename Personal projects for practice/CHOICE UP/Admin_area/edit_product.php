<?php
include('relations.php');
include('../includes/connection.php');
$product_id=$_GET['product_id'];
if (isset($_POST['insert_product']))
{
    $product_tittle=$_POST['product_tittle'];
    $product_tittle=$_POST['product_tittle'];
 $product_discription=$_POST['product_discription'];
 $product_keyword=$_POST['product_keywords'];
 $product_catagory=$_POST['product_catagories'];
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
     $update_query = "UPDATE `products` SET product_tittle = '$product_tittle', product_discription = '$product_discription', 
     product_keyword = '$product_keyword', catagory_id = '$product_catagory', product_image1 = '$file_name1', 
     product_image2 = '$file_name2', product_image3 = '$file_name3', product_price = '$product_price', 
     product_status = '$product_status' WHERE product_id = $product_id";
 
 $result_query = mysqli_query($con, $update_query);
 if ($result_query) {
     echo "<script>alert('Product has been updated successfully')</script>";
     header("Location: admin.php"); // refresh or action
     exit();
 }
 
 }
 }
?>
<body>
    
<div class="container mt-5">
<div class="container">
        <div>
            <h2 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">Edit Products</h2>
        </div>
</div>
        <form action="" method="POST" enctype="multipart/form-data">
            <div class="form outline md-4 w-50 m-auto">
            <?php
             global $con;
             $select_query="select * from `products` where product_id=$product_id";
             $result_query=mysqli_query($con,$select_query);
             $row=mysqli_fetch_assoc($result_query);
             $product_id=$row['product_id'];
             $product_tittle=$row['product_tittle'];
             $product_discription=$row['product_discription'];
             $product_keyword=$row['product_keyword'];
             $catagory_id=$row['catagory_id'];
             $product_image1=$row['product_image1'];
             $product_image2=$row['product_image2'];
             $product_image3=$row['product_image3'];
             $product_price=$row['product_price'];
              $product_id=$row['product_id'];
             $product_tittle=$row['product_tittle'];
             $product_discription=$row['product_discription'];
             $catagory_id=$row['catagory_id'];
             $product_image1=$row['product_image1'];
             $product_price=$row['product_price'];
             echo
              '
              <label for="product_tittle" class="form-label">Product Tittle*</label>
              <input type="text" name="product_tittle" id="product_tittle" class="form-control"
              placeholder="Enter Poduct Tittle" value="'.$product_tittle.'" autocomplete="off"required >
              </div>
              <div class="form outline md-4 w-50 m-auto">
                  <label for="product_discription" class="form-label">Product discription*</label>
              <input type="text" name="product_discription" id="product_discription" class="form-control"
              placeholder="Enter Poduct discription" value="'.$product_discription.'" autocomplete="off" required >
              </div>
              <div class="form outline md-4 w-50 m-auto">
                  <label for="product_keywords" class="form-label">Product Keywords*</label>
              <input type="text" name="product_keywords" id="product_keywords" class="form-control"
              placeholder="Enter Poduct keywords" value="'.$product_keyword.'" autocomplete="off" required >
              </div>
              <div class="form outline md-4 w-50 m-auto">
              <select name="product_catagories"  id=""class="product_catagory form-select mt-2"required>
                   <option value="">Select catagory</option>
              ';
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
            echo
            '
            </select>
            </div>
           <div class="form outline md-4 w-50 m-auto ">
               <label for="image">Choose Image 1*</label>
               <div class="d-flex">
               <input type="file" name="image1" value="" id="image" class="form-control   m-auto form-control-file"  accept="image/*" required>
               <img src="./images/'.$product_image1.'"<img class="card-img-top" style="height:100px;margin-right: 0px;width: 100px;">
               </div>
           </div>

           <div class="form outline md-4 w-50 m-auto">
               <label for="image">Choose Image 2*</label>
              <div class="d-flex">
               <input type="file" name="image2" value="" id="image" class="form-control m-auto form-control-file"  accept="image/*" required>
               <img src="./images/'.$product_image2.'"<img class="card-img-top" style="height:100px;margin-right: 0px;width: 100px;">
               </div>
           </div>
           <div class="form outline md-4 w-50 m-auto">
               <label for="image">Choose Image 3*</label>
               <div class="d-flex">
               <input type="file" name="image3" value="" id="image" class="form-control m-auto form-control-file"  accept="image/*" required>
               <img src="./images/'.$product_image3.'"<img class="card-img-top" style="height:100px;margin-right: 0px;width: 100px;">
               </div>
           </div>            
           <!--product Price-->
           <div class="form outline md-4 w-50 m-auto">
               <label for="product_price" class="form-label">Product Price*</label>
           <input type="text" name="product_price" value="'.$product_price.'" id="product_price" class="form-control" required
           placeholder="Enter Poduct Price" autocomplete="off" >
           </div>
           <div class="form outline md-4 w-50 m-auto my-2">
               <input class="bg-info border-0 px-3 btn" type="submit" value="Update product" name="insert_product" required>
           </div>
            ';
            ?>

                    

               
        </form>
</div>
</body>
</html>

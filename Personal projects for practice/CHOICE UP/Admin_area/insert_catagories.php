<?php
include'../includes/connection.php';
if (isset($_POST['Insert_cat']))
{
  $category_title = $_POST['cat_tittle'];
  $select_query="select * from `catagory` where catagory_tittle= '$category_title'";
  $result_select=mysqli_query($con,$select_query);
  $count =mysqli_num_rows($result_select);
  if ($count >0)
  {
    echo "<script>alert('Can't Create a dublicate catagory ')</script>";
  }
  else
  {
    $insert_query = "insert into `catagory` (catagory_tittle) value ('$category_title')";
  $result = mysqli_query($con, $insert_query);
  if ($result) {
    echo "<script>alert('Category has been added successfully')</script>";
    header("Location:admin.php?insert_Catagories"); // Replace "your_page.php" with the desired page to redirect
    exit();
  }
  }
}
?>
<form action="" method="post" class="mb-2">
<div class="input-group flex-nowrap w-90 mb-2">
  <span class="input-group-text bg-secondary" id="addon-wrapping"><i class="fa-sharp fa-regular fa-file-invoice-dollar fa-lg"></i></span>
  <input type="text" class="form-control" name="cat_tittle" placeholder="Insert Categories" aria-label="Username" aria-describedby="addon-wrapping">
</div>
<div class="input-group flex-nowrap w-10 mb-2">
  <input type="submit" class="border-0 p-2 bg-secondary my-3 btn" name="Insert_cat" value="Insert Categories" aria-label="Username" aria-describedby="addon-wrapping">
</div>
</form>

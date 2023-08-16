<?php
include'../includes/connection.php';
if (isset($_POST['Insert_col']))
{
  $colour_name = $_POST['col_name'];
  $select_query="select * from `colours_combination` where colour_name= 'red'";
  $result_select=mysqli_query($con,$select_query);
  $count =mysqli_num_rows($result_select);
  echo $count;
  if ($count > 0)
  {
    echo "<script>alert('Can't Create a dublicate color ')</script>";
  }
  else
  {
    $insert_query = "insert into `colours_combination` (colour_name) value ('$colour_name')";
  $result = mysqli_query($con, $insert_query);
  if ($result) {
    echo "<script>alert('Colour has been added successfully')</script>";
  }
  }
}
?>
<form  method="post" class="mb-2">
<div class="input-group flex-nowrap w-90 mb-2">
  <span class="input-group-text bg-secondary" id="addon-wrapping"><i class="fa-sharp fa-regular fa-file-invoice-dollar fa-lg"></i></span>
  <input type="text" class="form-control" name="col_name" placeholder="Insert Colour Name" aria-label="Username" aria-describedby="addon-wrapping">
</div>
<div class="input-group flex-nowrap w-10 mb-2 ">
  <input type="submit" class="border-0 p-2 bg-secondary my-3 btn text-center" name="Insert_col" value="Insert Colour" aria-label="Username" aria-describedby="addon-wrapping">
</div>
</form>
<div class="container">
    <div>
        <h2 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">Colours Available</h2>
    </div>
</div>
<table class="table table-bordered ">
    <thead class="bg-warning">
        <tr class=" text-center ">
            <th>Color Id</th>
            <th>Colour Name</th>
            <th>Delete</th>
        </tr>
    </thead>
    <tbody>
        <tr class='bg-lightt text-secondary text-center'>
            <?php
             global $con;
             $insert_query = "select * from `colours_combination`";
             $result_query = mysqli_query($con, $insert_query);
             while ($row = mysqli_fetch_assoc($result_query)) 
            {
                $color_tittle=$row['colour_name'];
                $color_id=$row['colour_id'];
                echo
                "
                <tr class='bg-lightt text-secondary text-center'>
                <td>$color_id</td>
                <td>$color_tittle</td>
                <td><a href='#' class='text-secondary'><i class='fa-solid fa-trash'></i></a>Delete</td>
                </tr>";
            }           
            ?>
        </tr>
    </tbody>
</table>
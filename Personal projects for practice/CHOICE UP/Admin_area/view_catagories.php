<?php
include('../includes/connection.php');
include('relations.php');
?>
<div class="container">
    <div>
        <h2 class="text-center mb-5 shadow-sm p-3" style="color: gray; ">Edit Products</h2>
    </div>
</div>
<table class="table table-bordered ">
    <thead class="bg-warning">
        <tr class=" text-center ">
            <th>Catagory Id</th>
            <th>Catagory Name</th>
            <th>Delete</th>
        </tr>
    </thead>
    <tbody>
        <tr class='bg-lightt text-secondary text-center'>
            <?php
             global $con;
             $insert_query = "select * from `catagory`";
             $result_query = mysqli_query($con, $insert_query);
             while ($row = mysqli_fetch_assoc($result_query)) 
            {
                $catagory_tittle=$row['catagory_tittle'];
                $catagory_id=$row['catagory_id'];
                echo
                "
                <tr class='bg-lightt text-secondary text-center'>
                <td>$catagory_id</td>
                <td>$catagory_tittle</td>
                <td><a href='#' class='text-secondary'><i class='fa-solid fa-trash'></i></a>Delete</td>
                </tr>";
            }           
            ?>
        </tr>
    </tbody>
</table>
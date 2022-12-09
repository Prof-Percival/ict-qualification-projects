main:
add $t0, $zero, $zero # $t0 = 0
addi $t1, $zero, 10
Loop: beq $t0, $t1, Exit
addi $t0, $t0, 1
j Loop
Exit:
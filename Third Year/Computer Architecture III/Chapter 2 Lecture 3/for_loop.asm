main:
addi $s1, $zero, 1 #$s1 = 1
addi $s2, $zero, 10
Loop:
slt $t0, $s1, $s2
beq $t0, $zero, Exit
addi $s1, $s1, 1
j Loop
Exit:
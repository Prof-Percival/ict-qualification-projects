.data

.text

addi $a0, $zero, 1 #transfer 1 to $a0 - value of g
addi $a1, $zero, 2 #transfer 2 to $a0 - value of g
addi $a2, $zero, 3 #transfer 3 to $a0 - value of g
addi $a3, $zero, 4 #transfer 4 to $a0 - value of g

leaf_example:	
	addi $sp, $sp, –4 # adjust stack to make room for 1 item
	sw $s0, 0($sp) # save register $s0  on stack for use afterwards
	
	add $t0,$a0,$a1 # register $t0 contains g + h
	add $t1,$a2,$a3 # register $t1 contains i + j
	sub $s0,$t0,$t1 # f = $t0 – $t1, which is (g + h)–(i + j)
	
	add $v0,$s0,$zero # returns f ($v0 = $s0 + 0)
	
	lw $s0, 0($sp) # restore register $s0 for caller
	addi $sp,$sp,4 # adjust stack to delete 1 item / restore stack pointer
	
	jr $ra # jump back to calling routine or return
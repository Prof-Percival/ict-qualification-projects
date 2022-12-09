.data

.text
leaf_example:
	addi $sp, $sp, –12 # adjust stack to make room for 3 items
	sw $t1, 8($sp) # save register $t1 for use afterwards
	sw $t0, 4($sp) # save register $t0 for use afterwards
	sw $s0, 0($sp) # save register $s0 for use afterwards
	
	add $t0,$a0,$a1 # register $t0 contains g + h
	add $t1,$a2,$a3 # register $t1 contains i + j
	sub $s0,$t0,$t1 # f = $t0 – $t1, which is (g + h)–(i + j)
	
	add $v0,$s0,$zero # returns f ($v0 = $s0 + 0)
	
	lw $s0, 0($sp) # restore register $s0 for caller
	lw $t0, 4($sp) # restore register $t0 for caller
	lw $t1, 8($sp) # restore register $t1 for caller
	addi $sp,$sp,12 # adjust stack to delete 3 items
	
	jr $ra # jump back to calling routine
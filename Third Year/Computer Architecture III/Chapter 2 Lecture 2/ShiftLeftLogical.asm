.data
a: .word 9 #9 base10 = 0000 0000 0000 0000 0000 0000 0000 1001 base2

.text
lw $s0, a #transfer or load 9 from memory into $s0
sll $t2, $s0, 4 # shift bits (1001 base2 = 9 base10) shift them to the left by 4 bits
		# OUTPUT: 0000 0000 0000 0000 0000 0000 1001 0000 base2 = 144 base10
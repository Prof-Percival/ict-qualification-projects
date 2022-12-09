.data
prompt: .asciiz "\Enter two numbers: " 			#prompt to enter two numbers
message: .asciiz "\The Sum of Two Numbers is: "	#display message and results

.text
li $v0, 4	#address for a string to print
la $a0, prompt	#load string address to register $a0
syscall		#print the string

li $v0, 5	#reads the first integer
syscall 	# do it

add $t0, $v0, $zero 	#transfer value to $t0

li $v0, 5	#reads the second integer
syscall 	# do it

add $t1, $v0, $zero 	#transfer value to $t1

li $v0, 4	#address for a string to prnt
la $a0, message # load string address to register $a0
syscall		#print string

li $v0, 1		#prepare to print integer / call service number 1 which is to print Integer
add $a0, $t0, $t1	#add the values and store them in argument register $a0 (prepare sum)
syscall

.data
.double
const3: 70.3788888878
const4: 49.53456788765

.float
a1: 56.367
a2: 12.4

.text
#Loading Double
ldc1 $f2, const3
ldc1 $f4, const4

#Loading Single
lwc1 $f2, a1
lwc1 $f4, a2

#Add Single and Double
add.s $f19, $f2, $f4
add.d $f20, $f2, $f4

#Multiply Single and Double
mul.s $f21, $f2, $f4
mul.d $f22, $f2, $f4

#Subtract Single and Double
sub.s $f23, $f2, $f4
sub.d $f24, $f2, $f4

#Divide Single and Double
div.s $f25, $f2, $f4
div.d $f26, $f2, $f4
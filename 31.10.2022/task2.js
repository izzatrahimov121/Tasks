let number =12345, sum=0;
while(number>0){
    sum+=number%10;
    number=(number-number%10)/10;
}
console.log(sum);
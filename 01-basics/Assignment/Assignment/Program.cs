

class Assignment
{
    static void Main()
    {
        double pi = 3.14159;
        int radius = 2;
        double areaOfCicle = pi * radius * radius;
        System.Console.WriteLine(areaOfCicle);

        int feet = 5;
        int inches = 7;
        double centimeters = (inches * 2.54) + (feet * 12.0 * 2.54);
        System.Console.WriteLine(centimeters);

        int number = 3852;  //input
        decimal decimal_number = number; //we upcasting (converting) the 'int' input value to 'decimal' type; so that, we can get fractional value while dividing the number below

        //Round down to previous thousand. Means, replace the last three digits with '000'. 
        int previous_thousand = number / 1000 * 1000; //'number / 1000' will integer divide (because the 'number' variable is an 'int') with 1000. So you will get '3' in this example. Then multiply the same with 1000. So it becomes '3000'

        //In Next few statements, we are trying to get last three digits from the number. 
        decimal last_three_digits_x = decimal_number / 1000; //In this example, the number is 3852. So "decimal_number / 1000" will get "3.852". 
        decimal last_three_digits_y = number / 1000; //"number / 1000" will get "3".

        decimal last_three_digits = (last_three_digits_x - last_three_digits_y) * 1000; //Then we will subtract these 'x' and 'y'. So "3.852 - 3" will be "0.852". Then we will multiply the same with 1000. So "0.852 * 1000" will be "852". In this way, we are getting the last three digits of the actual number.

        //Rounding means, the last three digits are greater than or equal to 500, we will consider the ceiling thousand; otherwise the floor 1000. Here, the last three digits "852" is greater than "500". So we will consider the "rounding_value" value is "1000". Means, we are going to add "1000" to "3000". So it becomes as "4000". 
        //In the other case (if the last three digits is less than 500), the "rounding_value" variable will be 0 (zero). Means, we are going to add "0" to "3000". So it remains as "3000".
        int rounding_value = (last_three_digits >= 500) ? 1000 : 0; //Here, the expression "last_three_digits >= 500" returns a boolean value(either true or false); If it is 'true', the 'rounding_value" will be '1000'; otherwise, '0'.

        int is_less_than_five_hundred = (number < 500) ? 1000 : 0; //in a different case, if the actual 'number' itself is less than 500 (Eg: 499), we need to round up to 1000 always. Means, any input number less than 500 gives result as '1000'.

        int nearest_thousand = previous_thousand + rounding_value + is_less_than_five_hundred;  //return the sum of all above three values
        System.Console.WriteLine(nearest_thousand); //Eg output: 4000

        int seconds = 288970; //input

        int remaining_seconds = seconds; //copying the actual input; so that, the original input will be persisted
        int seconds_per_minute = 60; //1 minute = 60 seconds
        int seconds_per_hour = 60 * 60; //1 hour = 60 minute (each minute is 60 seconds)
        int seconds_per_day = 24 * 60 * 60; //1 day = 24 hours (each hour is 60 minutes; and each minute is 60 seconds)

        int days = remaining_seconds / seconds_per_day; //divide the "remaining_seconds" with "number of seconds per day"
        remaining_seconds -= days * seconds_per_day; //subtract the number of seconds which equivalent to the number of days calculated above

        int hours = remaining_seconds / seconds_per_hour; //divide the "remaining_seconds" with "number of seconds per hour"
        remaining_seconds -= hours * seconds_per_hour; //subtract the number of seconds which equivalent to the number of hours calculated above
        int minutes = remaining_seconds / seconds_per_minute; //divide the "remaining_seconds" with "number of seconds per minute"
        remaining_seconds -= minutes * seconds_per_minute; //subtract the number of seconds which equivalent to the minutes of days calculated above

        System.Console.WriteLine(days + " days, " + hours + " hours, " + minutes + " minutes, " + remaining_seconds + " seconds");

        System.Console.ReadKey();   
    }
}

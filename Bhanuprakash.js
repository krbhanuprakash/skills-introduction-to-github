console.log("Welcome to Bhanuprakash.js! This is a new file to explore and learn.");

function fibonacciSeries(n) {
    let series = [0, 1];
    for (let i = 2; i < n; i++) {
        series.push(series[i - 1] + series[i - 2]);
    }
    return series.slice(0, n);
}

console.log(fibonacciSeries(10)); // Example: Prints the first 10 numbers in the Fibonacci series
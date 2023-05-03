# Basic mathematics
Some basic mathematics to be known to derive the complexity of the algorithms etc.  

## Sum of first 'n' numbers (Arithmetic series)
S = 0 + 1 + 2 + ..... + (n-1)<br>
S = (n-1) + (n-2) + (n-2) + ..... + 0
2S = 0 + n + n + n + ...... + 0 <br> 
*....n is counted (n-1) times*<br>
2S = n(n-1)<br>
**S = n(n-1)/2<br>**

## Geometric Series
S = 1 + 1/x + 1/x<sup>2</sup> + 1/x<sup>3</sup> + .....<br>
(1/x) * S = 1/x + 1/x<sup>2</sup> + 1/x<sup>3</sup> + ....<br>
S - (S/x) = 1<br>
S = x / (x - 1)

## Arithmetico-Geometric Series
As per [Wikipedia definition](https://en.wikipedia.org/wiki/Arithmetico-geometric_sequence), *arithmetico-geometric sequence is the result of term-by-term multiplication of a geometric progression with the corresponding terms of an arithmetic progression.*

For example, below is one of the demonstration of arithmetico-geometric series and solution.
![](Sorting/images/arithmetico-geometric.PNG)



# Método del trapecio

Este programa solicita que el usuario escriba en cuántos trapecios se deberá dividir la función que calcularemos, esta función de f(x) podemos definirla desde:

```sh
funcionDeEquis()
```

El método del trapecio utiliza desde su definición esta fórmula:
$$ \int_{a}^{b}\!f(x)\,dx \approx \frac{h}{2} [f(x_0) + 2\displaystyle\sum_{i=1}^{n-1}f(x_i) + f(x_n)] $$
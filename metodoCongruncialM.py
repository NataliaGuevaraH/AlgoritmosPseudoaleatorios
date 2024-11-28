# clase Metodo Congruencial

import math

class metodoCongruencialMultiplicativo:
    def __init__(self, x0, t, sumaResta, d, iteraciones):
        self.x0 = x0

        if sumaResta == True:
            self.a = 8*t + 3
        elif sumaResta == False:
             self.a = 8*t - 3
        
        self.m = 2*d
        self.iteraciones = iteraciones
        self.Validation()

        self.lista = []
        
    def Validation(self):
        while type(self.x0) != int:
             print('Error: Número no entero ingresados para X0')
             x0 = eval(input('Ingresa otro valor'))
             self.x0 = x0
        if self.x0 % 2 == 0:
             print('Error: X0 no debe ser par')
        if math.gcd(self.x0, self.m) != 1:
             print('Error: Valores x0 y m no son relativamente primos')

    def GenerateRandomValues(self):
            self.lista.append(self.x0)
            for _ in range(self.iteraciones):
                 x1 = (self.a * self.x0) % self.m
                 self.lista.append(x1)
                 self.x0 = x1
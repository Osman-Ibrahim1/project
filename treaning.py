import numpy as np

name=input('vad heter du\n')
print('välkommen till kursen ',name)
print('välkommen {} kursen '.format(name))
print('#########################################################')

tal1=float(input('skriv in ett tal'))
tal2=float(input('skriv in ett till tal'))
tal3=float(input('skriv in ett till tal'))
tal4=float(input('skriv in ett till tal'))

lowest= min(tal1,tal2,tal3)
highest= max(tal1,tal2,tal3)


print(f'Det läsgta taler var{lowest} och det högsta var {highest}')

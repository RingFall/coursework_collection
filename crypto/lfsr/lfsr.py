# -*- coding: UTF-8 -*-
def lfsr(seed, taps):
    sr, xor = seed, 0
    while 1:
        for t in taps:
            xor += int(sr[t-1])
        if xor%2 == 0.0:
            xor = 0
        else:
            xor = 1
        #print xor
        sr, xor = str(xor) + sr[:-1], 0
        print sr
        if sr == seed:
            break

lfsr('11010', (2,5))
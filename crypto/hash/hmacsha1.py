# -*- coding: UTF-8 -*-
from __future__ import print_function
import io
import struct
import string

#sha1

class Hasha1(object):
	dig = 20
	block = 64

	def __init__(self):

		self._h = (
            0x67452301,
            0xEFCDAB89,
            0x98BADCFE,
            0x10325476,
            0xC3D2E1F0,
        )

		self.remaining = b''

		self.bytes = 0

	def hash(self, arg):

		chunk = self.remaining + arg[:64]

		while len(chunk) == 64:
			self._h = process_chunk(chunk, *self._h)
			self.bytes += 64
			chunk = arg[:64]
			arg = arg[64:]

		self.remaining = chunk
		return self

	def getHex(self):
		return'%08x%08x%08x%08x%08x' % self.hashBlock()

	def hashBlock(self):

		message = self.remaining
		fullBytes = self.bytes + len(message)

		message += b'\x80'

		message += b'\x80' * ((56 - (fullBytes + 1) % 64) % 64)

		message_bit_length = fullBytes * 8
		message += struct.pack(b'>Q', message_bit_length)

		h = process_chunk(message[:64], *self._h)
		if len(message) == 64:
			return h
		return process_chunk(message[64:], *h)

def process_chunk(chunk, h0, h1, h2, h3, h4):

	assert len(chunk) == 64

	w = [0] * 80

	for i in range(16):
		w[i] = struct.unpack(b'>I', chunk[i * 4:i * 4 + 4])[0]

	for i in range(16, 80):
		w[i] = (w[i - 3] ^ w[i - 8] ^ w[i - 14] ^ w[i - 16])
		w[i] = left_rotate(w[i], 1)

	a = h0
	b = h1
	c = h2
	d = h3
	e = h4


	for i in range(80):
		if 0 <= i <= 19:
			f = d ^ (b & (c ^ d))
			k = 0x5A827999
		elif 20 <= i <= 39:
			f = b ^ c ^ d
			k = 0x6ED9EBA1
		elif 40 <= i <= 59:
			f = (b & c) | (b & d) | (c & d)
			k = 0x8F1BBCDC
		elif 60 <= i <= 79:
			f = b ^ c ^ d
			k = 0xCA62C1D6

		a, b, c, d, e = ((left_rotate(a, 5) + f + e + k + w[i]) & 0xffffffff,
						 a, left_rotate(b, 30), c, d)



	h0 = (h0 + a) & 0xffffffff
	h1 = (h1 + b) & 0xffffffff
	h2 = (h2 + c) & 0xffffffff
	h3 = (h3 + d) & 0xffffffff
	h4 = (h4 + e) & 0xffffffff
	return h0, h1, h2, h3, h4


def left_rotate(n, b):
    return ((n << b) | (n >> (32 - b))) & 0xffffffff


def sha1(message):

	return Hasha1().hash(message).getHex()

#hmac

trans_5C = bytes((x ^ 0x5C) for x in range(256))
trans_36 = bytes((x ^ 0x36) for x in range(256))

def addPad(key, size):
	while len(key) < size:
		key += '0'
	return key

def hmac(key, m):
	key2 = ""
	for i in range(0, 10):
		key2 = key2 + str((int(key)/pow(2, i)) % 2)
	block = 64
	out = 20
	#if key longer than the block, shorten using sha-1
	if len(key2) > block:
		key2 = sha1(m)

	#if key shorter than block, lengthen using pad of 0s
	if len(key2) < block:
		key2 = addPad(key2,block)

	tbl1 = string.maketrans(trans_5C, trans_5C)
	tbl2 = string.maketrans(trans_36, trans_36)

	o_key_pad = key2.translate(tbl1)
	i_key_pad = key2.translate(tbl2)


	preIn = i_key_pad + m
	inner = sha1(preIn)
	preOut = o_key_pad + inner
	outer = sha1(preOut)

	return outer


def main():

	m = raw_input("text:")
	k = input("key(number):")

	h = hmac(k,m)

	print("HMAC: ",h)
	print("len: ",len(h))

if __name__ == "__main__":
	main()
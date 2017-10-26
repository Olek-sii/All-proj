function doCalc(a, b, c) {
	var result = 0;
	switch (c) {
		case '+': result = a + b; break;
		case '-': result = a - b; break;
		case '*': result = a * b; break;
		case '/': result = a / b; break;
		default: result = "wrong input";
	}
	return result;
}

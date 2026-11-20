const centDigits = 2;
const halfwayDigit = 5;
const maxDigit = 9;

export const roundAmount = (input: string): string => {
  const decimalDotIndex = input.indexOf('.');
  if (decimalDotIndex === -1) return `${input}.00`;
  const fractionLength = input.length - decimalDotIndex - 1;
  if (fractionLength === 1) return `${input}0`;
  if (fractionLength === centDigits) return input;

  let hasCarryOver = false;
  const decimalPart = [0, 0];
  for (let index = input.length - 1; index > decimalDotIndex; index--) {
    let currentNumber = Number(input.charAt(index));
    let willCarryOver = currentNumber >= halfwayDigit && index > decimalDotIndex + centDigits;

    if (hasCarryOver) currentNumber++;
    if (currentNumber > maxDigit) {
      currentNumber = 0;
      willCarryOver = true;
    }

    hasCarryOver = willCarryOver;
    if (index === decimalDotIndex + 1) decimalPart[0] = currentNumber;
    if (index === decimalDotIndex + centDigits) decimalPart[1] = currentNumber;
  }

  let preDecimalNumber = Number(input.slice(0, decimalDotIndex + 1));
  if (hasCarryOver) preDecimalNumber++;

  return `${preDecimalNumber}.${decimalPart.join('')}`;
};

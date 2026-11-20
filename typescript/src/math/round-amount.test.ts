import { roundAmount } from './round-amount.ts';

describe('roundAmount', () => {
  it.each([
    ['1.005', '1.01'],
    ['9.999', '10.00'],
    ['7', '7.00'],
    ['6.99999', '7.00'],
    ['1.25', '1.25'],
    ['7.1', '7.10'],
    ['1.0049', '1.00'],
    ['1.250', '1.25']
  ])('rounds %s to %s', (input, expected) => {
    expect(roundAmount(input)).toBe(expected);
  });
});

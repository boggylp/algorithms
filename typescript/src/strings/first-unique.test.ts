import { firstUnique } from './first-unique.ts';

describe('firstUnique', () => {
  it.each([
    { input: 'swiss', expected: 'w' },
    { input: 'aabbc', expected: 'c' },
    { input: 'aabb', expected: null },
    { input: '', expected: null },
    { input: 'zab', expected: 'z' },
    { input: 'q', expected: 'q' },
    { input: 'aaa', expected: null }
  ])('returns $expected for "$input"', ({ input, expected }) => {
    expect(firstUnique(input)).toBe(expected);
  });
});

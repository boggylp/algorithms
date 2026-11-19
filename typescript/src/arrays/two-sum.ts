export const twoSum = (nums: readonly number[], target: number): [number, number] | null => {
  const seen = new Map<number, number>();
  for (const [index, num] of nums.entries()) {
    const partner = seen.get(target - num);
    if (partner !== undefined) {
      return [partner, index];
    }
    seen.set(num, index);
  }
  return null;
};

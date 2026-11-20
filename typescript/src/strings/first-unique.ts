// Given lowercase English letters, return the first character that occurs exactly once, or null if none does.
export const firstUnique = (input: string): string | null => {
  if (input.length === 0) return null;
  if (input.length === 1) return input;

  const lastChar = input.at(-1);
  const prevSolution = firstUnique(input.slice(0, -1));

  if (prevSolution && prevSolution !== lastChar) return prevSolution;

  if (prevSolution === lastChar) {
    const nextSolution = firstUnique(input.slice(1));
    return nextSolution === input[0] ? null : nextSolution;
  }

  return prevSolution ?? lastChar!;
};

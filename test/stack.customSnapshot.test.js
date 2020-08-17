const data = require('../template/SnapshotTestExampleStack.template.json');

expect.addSnapshotSerializer({
  test: val => typeof val === 'string',
  print: val => {
    const newVal = val.replace(/AssetParameters([A-Fa-f0-9]{64})(\w+)/, '[HASH REMOVED]');
	const newVal2 = newVal.replace(/(\w+) (\w+) for asset\s?(version)?\s?"([A-Fa-f0-9]{64})"/, '[HASH REMOVED]');
    return `"${newVal2}"`;
  },
});

test('Stack matches snapshot', () => {
  expect(data).toMatchSnapshot();
});


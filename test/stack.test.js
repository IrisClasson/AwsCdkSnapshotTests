const data = require('../template/SnapshotTestExampleStack.template.json');

test('Stack matches snapshot', () => {
  expect(data).toMatchSnapshot();
});
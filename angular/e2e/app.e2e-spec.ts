import { demoFirstAppTemplatePage } from './app.po';

describe('demoFirstApp App', function() {
  let page: demoFirstAppTemplatePage;

  beforeEach(() => {
    page = new demoFirstAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

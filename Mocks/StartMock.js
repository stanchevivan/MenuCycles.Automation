module.exports =
{
  *beforeSendRequest(requestDetail)
  {
    const mocks = require('./All_mocks');

    if (requestDetail.url.includes('menuservice//menucycles'))
    {
      return {
        response: mocks.menuCycles
      };
    }

    if (requestDetail.url.includes('qai/api/menuservice//user'))
    {
      return {
        response: mocks.user_locations_100
      };
    }

    if (requestDetail.url.includes('/menuservice/Search//menucycles'))
    {
      return {
        response: mocks.recipe_search
      };
    }
  }
};

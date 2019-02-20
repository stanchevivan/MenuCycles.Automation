module.exports =
{
  *beforeSendResponse(requestDetail, responseDetail)
  {
    const mocks = require('./All_mocks');
    if (requestDetail.url.includes('https://api-dev.fourth.com/qai/api/menuservice/User/Locations'))
    {
      return {
        response: mocks.locations_100(responseDetail)
      };
    }
  }
};

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using C__RIWI.src.Api.Dtos.Request;
using C__RIWI.src.Api.Dtos.Response;
using C__RIWI.src.Domain.Entities;
using C__RIWI.src.Domain.Repositories.Abstract_Repositories;
using C__RIWI.src.Infraestructure.Abstract_Services;

namespace C__RIWI.src.Infraestructure.Services
{
    public class OrderService : IOrderService<OrderResponse, OrderRequest> 
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
       public OrderService( IOrderRepository orderRepository , IMapper mapper)
       {
           _orderRepository = orderRepository;
           _mapper = mapper;
       }

       public async Task<OrderResponse> Create(OrderRequest request)
       {
           var order = _mapper.Map<Order>(request);
           await _orderRepository.Add(order);
           await _orderRepository.SaveChanges();
           return _mapper.Map<OrderResponse>(order);
       }

       public async Task Delete(int id)
       {
           var order = await  _orderRepository.GetById(id);
           if (order == null) throw new Exception("Order not found");
           _orderRepository.Delete(order);

           await _orderRepository.SaveChanges();

           
       }
          
       public async Task<IEnumerable<OrderResponse>> GetAll()
       { 
           var orders =  await _orderRepository.GetAll();
           return _mapper.Map<IEnumerable<OrderResponse>>(orders);
           
       }

       public async Task<OrderResponse> GetById(int id)
       {
           var order = await _orderRepository.GetById(id);
           return _mapper.Map<OrderResponse>(order);
           
       }

       public async Task<OrderResponse> Update(int id, OrderRequest request) 
       {
           var order = await _orderRepository.GetById(id);
           if (order == null)  throw new Exception("Order not found");

           order = _mapper.Map<Order>(request);

           _orderRepository.Update(order);

           await _orderRepository.SaveChanges();

           return _mapper.Map<OrderResponse>(order);
       } 
    }
}
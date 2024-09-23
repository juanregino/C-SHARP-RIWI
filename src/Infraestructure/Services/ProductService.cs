

using AutoMapper;
using C__RIWI.src.Api.Dtos.Request;
using C__RIWI.src.Api.Dtos.Response.BasicResponse;
using C__RIWI.src.Domain.Entities;
using C__RIWI.src.Domain.Repositories.Abstract_Repositories;
using C__RIWI.src.Infraestructure.Abstract_Services;
using Microsoft.AspNetCore.Mvc;

namespace C__RIWI.src.Infraestructure.Services
{
    public class ProductService: IProductService<ProductResponse, ProductRequest>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService( IProductRepository productRepository , IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        

        public async Task<ProductResponse> Create(ProductRequest request)
        {
            var product = _mapper.Map<Product>(request);

            await _productRepository.Add(product);

            await _productRepository.SaveChanges();
            return _mapper.Map<ProductResponse>(product);
            
        }

        public async Task Delete(int id)
        {
            var product = await  _productRepository.GetById(id);
            if (product == null) throw new Exception("Product not found");
            _productRepository.Delete(product);

            await _productRepository.SaveChanges();

            
        }
           
        public async Task<IEnumerable<ProductResponse>> GetAll()
        { 
            var products =  await _productRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductResponse>>(products);
            
        }

        public async Task<ProductResponse> GetById(int id)
        {
            var product = await _productRepository.GetById(id);
            return _mapper.Map<ProductResponse>(product);
            
        }

        public async Task<ProductResponse> Update(int id, ProductRequest request)
        {
            var product = await _productRepository.GetById(id);
            if (product == null)  throw new Exception("Product not found");

            product = _mapper.Map<Product>(request);

            _productRepository.Update(product);

            await _productRepository.SaveChanges();

            return _mapper.Map<ProductResponse>(product);
            
            
        }
    }
}